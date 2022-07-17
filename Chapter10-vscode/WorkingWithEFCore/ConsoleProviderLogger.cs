using static System.Console;
using Microsoft.Extensions.Logging;
namespace Packt.Shared;
public class ConsoleLoggerProvider : ILoggerProvider
{
    public ILogger CreateLogger(string categoryName)
    {
        return new ConsoleLogger();
    }
    public void Dispose()
    {
        // no-op
    }
}