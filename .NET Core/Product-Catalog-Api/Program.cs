using Product_Catalog_Api.Repository.Data;
using Product_Catalog_Api.Repository.Interface;
using Product_Catalog_Api.Repository.Repository;
using Product_Catalog_Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddScoped<IProductServices, ProductServices>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddTransient<ITransientService, IdService>();
builder.Services.AddScoped<IScopedService, IdService>();
builder.Services.AddSingleton<ISingletonService, IdService>();

builder.Services.AddSingleton<AppDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
