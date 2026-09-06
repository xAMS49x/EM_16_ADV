using System.Text;

namespace Libraries;

public class Logger
{
    public static StringBuilder log = new StringBuilder();

    public static void LogLine(string message)
    {
        Console.WriteLine(message);
        log.AppendLine("<program>: " + message);
    }

    public static void Log(string message)
    {
        Console.Write(message);
        log.Append(message);
    }

    public static string Ask(string prompt)
    {
        Console.WriteLine(prompt);
        log.Append($"<program>: {prompt}");

        string input = Console.ReadLine()!;
        log.AppendLine();
        log.AppendLine($"<user>: {input}");

        return input;
    }

    public static void SaveLog(int exitCode = 0)
    {
        log.AppendLine($"\nProcess finished with exit code {exitCode}");

        string logDirectory = "/home/ams/RiderProjects/promotionAssignment/logs";
        string fileName = $"log_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.log";
        string path = Path.Combine(logDirectory, fileName);

        File.WriteAllText(path, log.ToString());
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\nLog saved to: {path}");
        Console.ResetColor();
    }
}