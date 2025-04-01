using System.Runtime.CompilerServices;

namespace incapsulation;

public static class Debug
{
    public static void Log(
        string message,
        [CallerLineNumber] int lineNumber = 0,
        [CallerFilePath] string filePath = ""
    )
    {
        Console.WriteLine($"[{System.IO.Path.GetFileName(filePath)}:{lineNumber}] {message}");
    }
}