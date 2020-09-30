using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace AddressBookSystem
{
    class Contact
    {
        public static void Person()
        {
            List<string> data = new List<string>();
            List<string> entryReceived = new List<string>();
            data.Add("first name");
            data.Add("last name");
            data.Add("address");
            data.Add("city");
            data.Add("state");
            data.Add("zip code");
            data.Add("phone no.");
            data.Add("email id");
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine("Enter the {0}: ", data.ElementAt(i));
                string input = Console.ReadLine();
                entryReceived.Add(input);
            }
            Console.WriteLine("The contact details of person are given below");
            for (int j = 0; j < data.Count; j++)
            {
                Console.WriteLine(data.ElementAt(j) + " : " + entryReceived.ElementAt(j));
            }
        }
    }
}