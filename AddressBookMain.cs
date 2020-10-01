using System;
using System.Security.Cryptography.X509Certificates;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program!");
            Contact.CreateContact();
        }
    }
}
