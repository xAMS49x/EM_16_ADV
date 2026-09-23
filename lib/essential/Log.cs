using System.Text;

namespace Libraries;

public static class FileLogger
{
    private static readonly StringBuilder _logBuffer = new();

    public static void Log(string message)
    {
        _logBuffer.Append(message);
    }

    public static void LogLine(string message)
    {
        _logBuffer.AppendLine(message);
    }

    public static void SaveLog(int exitCode = 0)
    {
        _logBuffer.AppendLine($"\nProcess finished with exit code {exitCode}");

        string fileName = $"log_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.log";
        string logDirectory = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "logs"));
        Directory.CreateDirectory(logDirectory);
        string path = Path.Combine(logDirectory, fileName);
        
        File.WriteAllText(path, _logBuffer.ToString());

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\nLog saved to: {path}");
        Console.ResetColor();
    }
}
