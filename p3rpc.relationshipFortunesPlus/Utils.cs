using Reloaded.Mod.Interfaces;

namespace p3rpc.relationshipFortunesPlus;
internal class Utils
{
    private static ILogger _logger;
    internal static nint BaseAddress { get; private set; }

    internal static bool Initialise(ILogger logger)
    {
        _logger = logger;
        return true;
    }

    internal static void Log(string message)
    {
        _logger.WriteLine($"[Relationship Fortunes+] {message}");
    }

    internal static void LogError(string message, Exception e)
    {
        _logger.WriteLine($"[Relationship Fortunes+] {message}: {e.Message}", System.Drawing.Color.Red);
    }

    internal static void LogError(string message)
    {
        _logger.WriteLine($"[Relationship Fortunes+] {message}", System.Drawing.Color.Red);
    }
}
