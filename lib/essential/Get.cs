namespace Libraries;

public class Get
{
    public static string GetString(string msg)
    {
        return Logger.Ask(msg) ?? throw new InvalidOperationException();
    }

    public static int GetInt(string msg)
    {
        return Convert.ToInt32(GetString(msg));
    }

    public static double GetDouble(string msg)
    {
        return Convert.ToDouble(GetString(msg));
    }

    public static short GetShort(string msg)
    {
        return Convert.ToInt16(GetString(msg));
    }

    public static byte GetBytes(string msg)
    {
        return Convert.ToByte(GetString(msg));
    }

    public static float GetFloat(string msg)
    {
        return Convert.ToSingle(GetString(msg));
    }
        
    public static int GetRandom(int min, int max)
    {
        var random = new Random();
        return random.Next(min, max);
    }
}