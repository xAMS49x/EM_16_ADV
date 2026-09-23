namespace Libraries;

public class Debug
{
    static public void DebugL(string msg, dynamic value)
    {
        ConsoleHelper.WriteLine("Debug: " + msg +  " = " + value);
    }
}