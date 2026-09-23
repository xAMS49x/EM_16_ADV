namespace Libraries;

public class Validate
{
    public static bool ValidateStringLength(string text, int maxLength, int minLength = 0)
    {
        return text.Trim().Length < minLength || text.Trim().Length > maxLength;
    }

    public static bool ValidateEmptyString(string text)
    {
        return text.Length <= 0;
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