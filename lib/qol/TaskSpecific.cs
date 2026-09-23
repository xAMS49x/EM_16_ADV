

namespace Libraries;

public class TaskSpecific
{
    
    // public static int CoinFlip()
    // {
    //     var coinToss = new Random();
    //     int roll = coinToss.Next(1, 1001);
    //
    //     switch (roll)
    //     {
    //         case <= 498:
    //             return 3;
    //
    //         case <= 996:
    //             return 1;
    //
    //         default:
    //             return 10;
    //     }
    // }
    //
    // public static short DiceRoll(string name, byte die1, byte die2, byte result)
    // {
    //     LogLine($"{name} throws the dice!");
    //
    //     for (int i = 1; i <= 4; i++)
    //     {
    //         Log($"{name} rolled: {die1} and {die2}\n");
    //         result = (byte)(die1 + die2);
    //     }
    //
    //     return result;
    // }

    
    public static void ColoredValue<T>(string msg, T value, ConsoleColor color = ConsoleColor.Green)
    {
        string textValue = Convert.ToString(value);
        ConsoleHelper.Write(msg);
        Console.ForegroundColor = color;
        ConsoleHelper.Write(textValue + "\n");
        Console.ResetColor();
    }
    
    public static void ColoredMoney<T>(string msg, T value, string moneySymbol = "₴", ConsoleColor color = ConsoleColor.Green)
    {
        ConsoleHelper.Write(msg);
        Console.ForegroundColor = color;
        ConsoleHelper.Write(value + moneySymbol + "\n");
        Console.ResetColor();
    }

    public static bool IsInRange(int value, int min, int max)
    {
        if (value > min && value < max)
        {
            return true;
        }

        return false;
    }

    public static void RepeatFunctionBlock()
    {
        if (Console.ReadKey().Key != ConsoleKey.Y) return;
        ConsoleHelper.Write("\n");
    }

    public static void PressAnyKeyToContinue()
    {
        ConsoleHelper.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
}
