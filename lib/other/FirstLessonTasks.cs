using Libraries;
using static Libraries.Debug;
namespace Tasks;

public class FirstLessonTasks
{
    public static void FitnessTracker()
    {
        float goal =
            Get.GetFloat("Welcome to AMS's Basic Fitness Tracker!\nEnter your goal (steps): ");
        if (goal <= 0)
            throw new ApplicationException("Value cannot be negative or zero.");


        float current = Get.GetFloat("Enter your current results: ");
        if (current < 0)
            throw new ApplicationException("Value cannot be negative.");


        float percentage = (current / goal) * 100;
        
        if (percentage < 71)
            Logger.LogLine("It's a shoddy job, you need to move more!");


        else if (percentage > 70 && percentage < 91)
            Logger.LogLine("Solid effort, but you need to do better!");


        else if (percentage > 89 && percentage < 100)
            Logger.LogLine("Within striking distance, keep going!");


        else if (percentage >= 100 && percentage < 200)
            Logger.LogLine("Goal reached!");


        else if (percentage >= 200)
            Logger.LogLine("You are on top of the world!!!");
    }

    public static void TechShopCheckout()
    {
        float cashback = 0f;
        float discount = 0f;
        bool hasCard = false;

        float price = Get.GetFloat("\tCHECKOUT\nEnter your order price: ");
        if (Validate.IsZeroOrNegative(price))
            throw new ApplicationException("Value cannot be negative or zero.");


        Logger.LogLine("Do you have our reward card?\n\tY - YES\n\tN - NO");
        if (Console.ReadKey().Key == ConsoleKey.Y)
        {
            hasCard = true;
        }
        

        Logger.LogLine("");


        if (price >= 2000)
        {
            cashback = 0.01f;


            if (price >= 10000)
            {
                cashback = 0.05f;
            }
        }

        if (hasCard)
        {
            discount = 0.03f;
            if (price >= 20000)
                discount = +0.05f;
        }

        TaskSpecific.ColoredMoney("Total price: ", price);
        cashback = price * cashback;
        discount = price * discount;
        price -= discount;
        price -= cashback;
        TaskSpecific.ColoredValue("Has reward card: ", hasCard);
        TaskSpecific.ColoredMoney("Discount: -", discount);
        TaskSpecific.ColoredMoney("Cashback: +", cashback);
        TaskSpecific.ColoredMoney("Price with discounts: ", price);
    }

    public static void ElectricityBill()
    {
        float kilowattCost = 0;
        float endCost = 0;
        short consumedPower = Get.GetShort(
            "Church of The Isotope Power Supplement requires you to share your electricity meter readings (kWh):");
        if (Validate.IsZeroOrNegative(consumedPower))
        {
            throw new ApplicationException("Value cannot be negative or zero.");
        }


        kilowattCost = 1.44f;
        endCost += 100 * kilowattCost;


        if (!(consumedPower - 100 < 0))
        {
            kilowattCost = 1.68f;
            endCost += 500 * kilowattCost;
        }

        if (!(consumedPower - 600 < 0))
        {
            consumedPower -= 600;
            kilowattCost = 1.92f;
            endCost += consumedPower * kilowattCost;
        }

        TaskSpecific.ColoredMoney("Your debt to Church of The Isotope Power Supplement: ", endCost);
        
    }
    
}