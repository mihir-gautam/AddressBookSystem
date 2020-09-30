using System;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace AddressBookSystem
{
    class CreateContact
    {
        public static void Person()
        {
            List<string> data = new List<string>();
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
            }
        }
    }
}