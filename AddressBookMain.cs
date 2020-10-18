using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        AddressBook book;
        public HashSet<Contact> ContactSet;
        public AddressBookMain()
        {
            ContactSet = new HashSet<Contact>();
            book = new AddressBook();
        }
        static void Main(string[] args)
        {
            AddressBookMain newProgram = new AddressBookMain();
            Console.WriteLine("Welcome to the Address Book Program!");
            bool exist = true;
            while (exist)
            {
                string BookName;
                ArrayList ContactList = new ArrayList();
                HashSet<Contact> ContactSet = new HashSet<Contact>();
                Dictionary<string, HashSet<Contact>> Book = new Dictionary<string, HashSet<Contact>>();
 
                Console.WriteLine("Enter new address book name : ");
                BookName = Console.ReadLine();
                Console.WriteLine("Select the option. \n1. Add new contact. \n2. Edit existing contact. \n3. Delete existing contact \n4. Exit.");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            newProgram.book.AddPerson();
                            if (newProgram.book.CheckDuplicate())
                            { break; }
                            else
                            {
                                Book.Add(BookName, ContactSet);
                                Console.WriteLine("Contact added!");
                                Console.WriteLine("New count of contacts in address book : " + Book.Count);
                                break;
                            }
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the first name of that person: ");
                            newProgram.book.EditPersonDetails();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the first name of that person: ");
                            newProgram.book.DeletePersonDetails();
                            Console.WriteLine("New count of contacts in address book : " + Book.Count);
                            break;
                        }
                    case 4:
                        {
                            exist = false;
                            break;
                        }
                }
            }
        }
    }
}