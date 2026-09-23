namespace Libraries;

public static class ConsoleHelper
{
    public static void WriteLine(string message, bool shouldLog = true)
    {
        Console.WriteLine(message);

        if (shouldLog)
        {
            FileLogger.LogLine($"<program>: {message}");
        }
    }

    public static void Write(string message, bool shouldLog = true)
    {
        Console.Write(message);

        if (shouldLog)
        {
            FileLogger.Log(message);
        }
    }

    public static string Ask(string prompt, bool shouldLog = true)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine() ?? string.Empty;

        if (shouldLog)
        {
            FileLogger.LogLine($"<program>: {prompt}");
            FileLogger.LogLine($"<user>: {input}");
        }

        return input;
    }
    
    
}
