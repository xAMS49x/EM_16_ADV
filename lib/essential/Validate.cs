namespace Libraries;

public class Validate
{
    public static bool ValidateStringLength(string text, int minLength, int maxLength)
    {
        if (text.Trim().Length < minLength || text.Trim().Length > maxLength)
        {
            return true;
        }

        return false;
    }

    public static bool IsZeroOrNegative(dynamic value)
    {
        if (value <= 0)
        {
            return true;
        }
        return false;
    }
        
    public static bool ValidateRange(byte value, int min, int max)
    {
        if (value < min || value > max)
        {
            return false;
        }

        return true;
    }
}