using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Permissions;

class Program
{
    static void Main(string[] args)
    {
        Menu menu= new Menu();
        bool done = false;
        int userResponse;
        do 
        {
            userResponse = menu.ProcessMenu();
            switch (userResponse)
            {
                case 1:
                // Create new Journal Entry
                // Add entry to list of journal entries
                break;
                case 2:
                // Display Journal Entries
                break;
                case 3:
                // Save journal to file
                break;
                case 4:
                // Load journal from file
                break;
                case 5:
                    done = true;
                    break;
            }
        } while (!done);
    }
}