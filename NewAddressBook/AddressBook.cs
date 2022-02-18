using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAddressBook
{
    internal class AddressBook
    {
        public Dictionary<string, Contact> contacts;

        public AddressBook()
        {
            contacts = new Dictionary<string, Contact>();
        }

        public void CreateContact()
        {
            Contact tempContact = new Contact();
            tempContact.GetUserInfo();
            string name = tempContact.GetName();
            if (contacts.ContainsKey(name) is false)
            {
                contacts.Add(name, tempContact);
            }
            else
            {
                Console.WriteLine("erorr");
            }
        }

        public void AddContacts()
        {
            Contact tempContact = new Contact();
            tempContact.GetUserInfo();
            string name = tempContact.GetName();
            if (contacts.ContainsKey(name) is false)
            {
                contacts.Add(name, tempContact);
            }
            else
            {
                Console.WriteLine("erorr");
            }
        }


        public void EditContacts()
        {
            Contact tempContact = new Contact();
            tempContact.GetUserInfo();
            string name = tempContact.GetName();
            if (contacts.ContainsKey(name) is false)
            {
                contacts.Add(name, tempContact);
            }
            else
            {
                Console.WriteLine("erorr");
            }
        }

        public void DeleteContacts()
        {
            Contact tempContact = new Contact();
            tempContact.GetUserInfo();
            string name = tempContact.GetName();
            if (contacts.ContainsKey(name) is false)
            {
                contacts.Add(name, tempContact);
            }
            else
            {
                Console.WriteLine("erorr");
            }
        }

        public void AddMultiple()
        {
            Console.WriteLine("Enter no of contacts to add");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                CreateContact();
            }
            Display();
            Console.WriteLine("Successfully Added New Contacts");
        }

        public Dictionary<string, AddressBook> Library;


       
        public void Display()
        {
            foreach (string name in contacts.Keys)
                contacts[name].Display();
        }
    }
}
