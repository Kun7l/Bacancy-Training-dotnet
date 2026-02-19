using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

public class QueryCounterInterceptor : DbCommandInterceptor
{
    public int QueryCount { get; private set; }

    public override InterceptionResult<DbDataReader> ReaderExecuting(
        DbCommand command,
        CommandEventData eventData,
        InterceptionResult<DbDataReader> result)
    {
        QueryCount++;
        Console.WriteLine($"Query #{QueryCount} executed");
        return base.ReaderExecuting(command, eventData, result);
    }
}
