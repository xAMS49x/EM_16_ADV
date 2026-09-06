using Libraries;
using Tasks;

namespace promotionAssignment;

internal class Program
{
    static void Main(string[] args)
    {
        Funnies.FunnyPhrase();
        
        var choice = Get.GetBytes("Welcome back. Choose the task (1-3)\n\t1. Fitness Tracker\n\t2. Shop Checkout\n\t3. Electricity Bills\n\t0. Exit");
        if (!Validate.ValidateRange(choice, 0, 3))
        {
            throw new ApplicationException("No such task.");
        }

        switch (choice)
        {
            case 0:
                break;
            // Task №1
            case 1:
                FirstLessonTasks.FitnessTracker();
                break;

            // Task №2
            case 2:
                FirstLessonTasks.TechShopCheckout();
                break;

            // Task №3
            case 3:
                FirstLessonTasks.ElectricityBill();
                break;
            
            default:
                throw new ArgumentOutOfRangeException();
        }

        Logger.SaveLog(0);
    }
}