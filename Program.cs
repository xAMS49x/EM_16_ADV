using Libraries;
using promotionAssignment.Classes;

namespace Homework5
{
    internal class Program
    {
        static void Main()
        {
            PhoneBook newPhoneBook = new PhoneBook();
            ConsoleHelper.WriteLine("Welcome! Phonebook v1.1 is running.");
            byte phoneBookChoice = TaskHelper.GetTaskChoice(
                "Phonebook Menu:\n\t1. Add contact\n\t2. Edit contact\n\t3. Delete contact\n\t4. Search contacts\n\t5. Show full contact list");


            while (true)
            {
                switch (phoneBookChoice)

                {
                    case 1:
                        string number = Get.GetString("Enter the number to add:");
                        string name = Get.GetString("Enter the name:");
                        if (newPhoneBook.CreateEntry(name, number))
                            ConsoleHelper.WriteLine("Added new entry successfully.");
                        else
                            throw new ApplicationException("Failed to create new entry.");
                        break;

                    case 2:
                        string oldName = Get.GetString("Enter the name you want to change:");
                        string newName = Get.GetString("Enter new name for the contact:");
                        if (newPhoneBook.UpdateEntry(oldName, newName))
                            ConsoleHelper.WriteLine("Updated the entry successfully.");
                        else
                            throw new ApplicationException("Failed to update the entry.");
                        break;

                    case 3:
                        string entry = Get.GetString("Enter the name you want to delete:");
                        if (newPhoneBook.DeleteEntry(entry))
                            ConsoleHelper.WriteLine("Deleted the entry successfully.");
                        else
                            ConsoleHelper.WriteLine("Failed to delete the entry.");

                        break;

                    case 4:
                        string query = newPhoneBook.GetEntry("Search contacts:");
                        ConsoleHelper.WriteLine("Search results: " + query);

                        break;

                    case 5:
                        ConsoleHelper.WriteLine("--- All entries ---");
                        newPhoneBook.GetAllEntries();

                        break;

                    case 0:
                        return;

                    default:
                        throw new ApplicationException("Unknown exception occured.");
                }

                phoneBookChoice = TaskHelper.GetTaskChoice(
                    "Phonebook Menu:\n\t1. Add contact\n\t2. Edit contact\n\t3. Delete contact\n\t4. Search contacts\n\t5. Show full contact list");
            }
        }
    }
}