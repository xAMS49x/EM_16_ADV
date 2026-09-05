using System.Runtime.InteropServices.JavaScript;
using Libraries;

namespace promotionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var choice = GetValidateLog.GetBytes("Welcome back. Choose the task to see (1-3): ");
            if (!GetValidateLog.ValidateRange(choice, 1, 3))
            {
                throw new ApplicationException("No such task.");
            }

            switch (choice)
            {
                case 1:
                    float goal =
                        GetValidateLog.GetFloat("Welcome to AMS's Basic Fitness Tracker!\nEnter your goal (steps): ");
                    if (goal <= 0)
                        throw new ApplicationException("Error: Value cannot be negative or zero.");


                    float current = GetValidateLog.GetFloat("Enter your current results: ");
                    if (current < 0)
                        throw new ApplicationException("Error: Value cannot be negative.");


                    float percentage = (current / goal) * 100;


                    Math.Round(percentage);

                    if (percentage < 70)
                        GetValidateLog.LogLine("It's a shoddy job, you need to move more!");


                    else if (percentage > 70 && percentage < 90)
                        GetValidateLog.LogLine("Solid effort, but you need to do better!");


                    else if (percentage > 90 && percentage < 99)
                        GetValidateLog.LogLine("Within striking distance, keep going!");


                    else if (percentage > 100 && percentage < 199)
                        GetValidateLog.LogLine("Goal reached!");


                    else if (percentage > 200)
                        GetValidateLog.LogLine("You are on top of the world!!!");


                    break;

                case 2:
                    float cashback = 0f;
                    float discount = 0f;
                    bool hasCard = false;
                    float price = GetValidateLog.GetFloat("\tCHECKUP\nEnter your order price: ");
                    float startPrice = price;
                    
                    GetValidateLog.LogLine("Do you have our reward card?\n\tY - YES\n\tN - NO");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                        hasCard = true;
                    GetValidateLog.LogLine("");


                    if (price >= 2000)
                    {
                        cashback = 0.01f;
                        GetValidateLog.LogLine("debug: cashback: " + cashback);
                        

                        if (price >= 10000)
                        {
                            cashback = 0.05f;
                            GetValidateLog.LogLine("debug: cashback: " + cashback);
                        }
                    }
                    if (hasCard)
                    {
                        discount = 0.03f;
                        GetValidateLog.LogLine("debug: discount: " + discount);
                        if (price  >= 20000)
                            discount =+ 0.05f;
                        GetValidateLog.LogLine("debug: discount: " + discount);
                    }
                    
                    cashback -= price * cashback;
                    GetValidateLog.LogLine("debug: cashback: " + cashback);
                    discount -= price * discount;
                    GetValidateLog.LogLine("debug: discount: " + discount);
                    price -= price - discount;
                    GetValidateLog.LogLine("debug: price: " + price);
                    price -= price - cashback;
                    GetValidateLog.LogLine("debug: price: " + price);
                    
                    TaskSpecific.ColoredFloat("Total price: ", startPrice);
                    TaskSpecific.ColoredValue("Has reward card: ", hasCard);
                    TaskSpecific.ColoredFloat("Discount: ", discount);
                    TaskSpecific.ColoredFloat("Cashback: ", cashback);
                    TaskSpecific.ColoredFloat("Price with discounts: ", price);

                    break;
            }
            GetValidateLog.SaveLog(0);
        }
    }
}