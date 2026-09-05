using System;
using static Libraries.GetValidateLog;

namespace Libraries;

public class TaskSpecific
{
    // public static int[] GetArray()
    // {
    //     var size = GetInt("Enter the size of the array: ");
    //     var min = GetInt("Enter the min number value for the number generation: ");
    //     var max = GetInt("Enter the max number value for the number generation:\n");
    //
    //     if (size <= 0)
    //         throw new ArgumentException("Array size must be greater than zero!");
    //
    //     if (min > max)
    //         throw new ArgumentException("Min value must be less than max value!");
    //         
    //     int[] array = new int[size];
    //     for (int i = 0; i < size; i++)
    //     {
    //         array[i] = GetRandom(min, max + 1);
    //     }
    //         
    //     return array;
    // }
    
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

    
    public static void ColoredValue(string msg, dynamic value, ConsoleColor color = ConsoleColor.Green)
    {
        Log(msg);
        Console.ForegroundColor = color;
        Log(value + "\n");
        Console.ResetColor();
    }
    
    public static void ColoredFloat(string msg, float value, ConsoleColor color = ConsoleColor.Green)
    {
        Log(msg);
        Console.ForegroundColor = color;
        Log(value + "\n");
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
        LogLine("\n");
    }

    public static void PressAnyKeyToContinue()
    {
        LogLine("\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
    
    
}
