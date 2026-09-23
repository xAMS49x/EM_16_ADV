using Libraries;

namespace promotionAssignment.Classes;

class PhoneBook
{
    Dictionary<string, string> phoneBook = new Dictionary<string, string>();

    public bool CreateEntry(string entryName, string entryPhoneNumber)
    {
        if (Validate.ValidateEmptyString(entryName))
            throw new ApplicationException("Name cannot be empty!");

        if (phoneBook.ContainsValue(entryPhoneNumber))
            throw new ApplicationException("Phone number already exists!");

        phoneBook.Add(entryName, entryPhoneNumber);

        return true;
    }

    public bool UpdateEntry(string oldName, string newName)
    {
        if (Validate.ValidateEmptyString(newName))
            throw new ApplicationException("New name cannot be empty!");

        if (!phoneBook.ContainsKey(oldName))
            throw new ApplicationException("Old name does not exist!");

        string phoneNumber = phoneBook[oldName];
        phoneBook.Remove(oldName);
        phoneBook[newName] = phoneNumber;
        
        return true;
    }

    public bool DeleteEntry(string entryName)
    {
        if (Validate.ValidateEmptyString(entryName))
            throw new ApplicationException("Name cannot be empty!");

        if (!phoneBook.ContainsKey(entryName))
            throw new ApplicationException("Name does not exist!");

        return phoneBook.Remove(entryName);
    }

    public string GetEntry(string query)
    {
        if (Validate.ValidateEmptyString(query))
            throw new ApplicationException("Query cannot be empty!");


        if (!phoneBook.TryGetValue(query, out var entry))
            throw new ApplicationException("Name does not exist!");


        return phoneBook[query];
    }

    public void GetAllEntries()
    {
        int index = 1;
        foreach (KeyValuePair<string, string> kvp in phoneBook)
        {
            ConsoleHelper.WriteLine($"{index}. {kvp.Key}: {kvp.Value}");
            index++;
        }
    }
}