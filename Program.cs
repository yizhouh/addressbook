using System;
using System.Collections.Generic;

namespace adressbook
{
    class Program
    {
       // static AddressbookEntry[] addressbook = new AddressbookEntry[10]{};
        static List<AddressbookEntry> addressbook = new List<AddressbookEntry>();
        static void Main(string[] args)
        {
            //get input option(add , search) from user
            //using while loop until user put "quit" to exit the application
            string userInput;
            Console.WriteLine("Welcome to Addressbook!!!\nWhat would like to do (add, quit, print or search):  ");
            userInput = Console.ReadLine();
            //int count = 0;
            while (true)
            {
                if (userInput.ToLower() != "quit")
                {
                    if(userInput.ToLower() == "add")
                    {
                        //do add
                        // addressbook[count] = new AddressbookEntry();
                        // addressbook[count].AddEntry();
                        // count++;
                        AddressbookEntry entry = new AddressbookEntry();
                        entry.AddEntry();
                        addressbook.Add(entry);
                        Console.WriteLine("You have added an entry, what is next:  ");
                        userInput = Console.ReadLine();

                    }
                    else if(userInput.ToLower() == "search")
                    {
                        //do search
                        Console.WriteLine("Please enter the Lastname you want to search:  ");
                        string searchName = Console.ReadLine();
                        Search(searchName);
                    }
                    else if(userInput.ToLower() == "print")
                    {
                        PrintEntries();
                        Console.WriteLine("You have printed all the entries, what is next:  ");
                        userInput = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("See you next time!!!");
                    break;
                }

            }


        }

        public static void PrintEntries()
        {
            Console.WriteLine("There are {0} entries in Addressbook.", addressbook.Count);
            foreach (var item in addressbook)
            {
                Console.WriteLine("Name: {0},  Phone number: {1},  Email: {2}", item.FirstName+" "+item.LastName, item.PhoneNumber, item.EmailAddress);
            }
        }

        public static void Search(string lastname)
        {
            //set found as condition of search result, print result if found, otherwise print no match result.
            bool found = false;
            Console.WriteLine("Here is the search result：  ");
            foreach (var item in addressbook)
            {
                if(item.LastName == lastname)
                {
                    found = true;
                    Console.WriteLine("Name: {0},  Phone number: {1},  Email: {2}", item.FirstName + " " + item.LastName, item.PhoneNumber, item.EmailAddress);
                }
            }

            if(found == false)
            {
                Console.WriteLine("No match result");
            }
        }

    }
}
