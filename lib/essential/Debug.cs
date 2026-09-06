namespace Libraries;

public class Debug
{
    static public void DebugL(string msg, dynamic value)
    {
        Logger.LogLine("Debug: " + msg +  " = " + value);
    }
}