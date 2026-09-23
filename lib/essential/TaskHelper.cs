namespace Libraries;

public class TaskHelper
{
    public static byte GetTaskChoice(string msg)
    {
        // Template for message: "Welcome back. Choose the task (1-3)\n\t1. Fitness Tracker\n\t2. Shop Checkout\n\t3. Electricity Bills"
        var choice = Get.GetBytes(msg + "\n\t0. Exit");
        
        if (!Validate.ValidateRange(choice, 0, choice))
            throw new ApplicationException("No such task.");
        

        return choice;
    }
}