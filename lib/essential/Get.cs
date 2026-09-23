namespace Libraries;

public static class Get
{
    private static readonly Random _random = new();

    private delegate bool TryParseDelegate<T>(string input, out T result);

    private static string _errorMessage = "An error occured: please enter a valid value.";
    
    private static T GetValue<T>(string msg, TryParseDelegate<T> tryParse, bool shouldLog = true)
    {
        string errorMessage = _errorMessage;
        
        while (true)
        {
            string input = GetString(msg, shouldLog);

            if (tryParse(input, out T result))
            {
                return result;
            }

            throw new ApplicationException(errorMessage);
        }
    }
    
    public static string GetString(string msg, bool shouldLog = true)
    {
        return ConsoleHelper.Ask(msg, shouldLog);
    }

    public static int GetInt(string msg, bool shouldLog = true)
    {
        return GetValue<int>(msg, int.TryParse, shouldLog);
    }

    public static double GetDouble(string msg, bool shouldLog = true)
    {
        return GetValue<double>(msg, double.TryParse, shouldLog);
    }

    public static short GetShort(string msg, bool shouldLog = true)
    {
        return GetValue<short>(msg, short.TryParse, shouldLog);
    }

    public static byte GetBytes(string msg, bool shouldLog = true) // Перейменовано з GetBytes на GetByte, оскільки повертається один byte
    {
        return GetValue<byte>(msg, byte.TryParse, shouldLog);
    }

    public static float GetFloat(string msg, bool shouldLog = true)
    {
        return GetValue<float>(msg, float.TryParse, shouldLog);
    }

    public static int GetRandom(int min, int max)
    {
        return _random.Next(min, max);
    }
}