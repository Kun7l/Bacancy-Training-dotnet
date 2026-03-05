using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;

namespace Event_Management_System.Middlewares
{
    public class UserRateLimitingMiddleware
    {
        private const int Limit = 10;
        private static readonly TimeSpan Window = TimeSpan.FromMinutes(1);

        private readonly RequestDelegate _next;
        private readonly IMemoryCache _cache;

        private class RateLimitEntry
        {
            public int Count { get; set; }
            public DateTime WindowStart { get; set; }
        }

        public UserRateLimitingMiddleware(RequestDelegate next, IMemoryCache cache)
        {
            _next = next;
            _cache = cache;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var userId = context.User.FindFirstValue(ClaimTypes.NameIdentifier)
                         ?? context.Connection.RemoteIpAddress?.ToString()
                         ?? "anonymous";

            var cacheKey = $"RateLimit_{userId}";

            var entry = _cache.GetOrCreate(cacheKey, cacheEntry =>
            {
                cacheEntry.AbsoluteExpirationRelativeToNow = Window;
                return new RateLimitEntry
                {
                    Count = 0,
                    WindowStart = DateTime.UtcNow
                };
            })!;

            bool isLimited;

            lock (entry)
            {
                var now = DateTime.UtcNow;

                if (now - entry.WindowStart >= Window)
                {
                    entry.WindowStart = now;
                    entry.Count = 0;
                }

                entry.Count++;
                isLimited = entry.Count > Limit;
            }

            if (isLimited)
            {
                context.Response.StatusCode = StatusCodes.Status429TooManyRequests;
                context.Response.ContentType = "application/json";

                var response = new
                {
                    statusCode = context.Response.StatusCode,
                    message = "Too many attempts. You are limited to 10 requests per minute.",
                };

                var payload = JsonSerializer.Serialize(response);
                await context.Response.WriteAsync(payload);
                return;
            }

            await _next(context);
        }
    }
}
