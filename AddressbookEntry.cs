using System;
namespace adressbook
{
    public class AddressbookEntry
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string PhoneNumber { get; private set; }

        public string EmailAddress { get; private set; }

        // public AddressbookEntry(){}

        // public AddressbookEntry(string firstName, string lastName, string phoneNumber, string emailAddress)
        // {
        //     this.FirstName = firstName;
        //     this.LastName = lastName;
        //     this.PhoneNumber = phoneNumber;
        //     this.EmailAddress = emailAddress;

        // }


        public void AddEntry()
        {
            Console.WriteLine("What is the first name:  ");
            this.FirstName = Console.ReadLine();
            Console.WriteLine("What is the last name:  ");
            this.LastName = Console.ReadLine();

            Console.WriteLine("What is the phone number:  ");
            this.PhoneNumber = Console.ReadLine();

            Console.WriteLine("What is the email address:  ");
            this.EmailAddress = Console.ReadLine();

        }



    }
}