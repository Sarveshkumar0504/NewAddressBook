using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book");
            AddressBook address = new AddressBook();
            //address.CreateContact();
            //address.Display();
            //Console.ReadKey();


            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Number to Execute the Address book Program \n1. Create contacts \n2. Add contact \n3. Edit contact \n4. Exit");
                Console.WriteLine("\nEnter Number to Execute the Address book Program \n1. Create contacts \n2. Add contact \n3. Edit contact \n4. Delete Contact \n5. Add Multiple Contacts \n6. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        address.CreateContact();
                        address.Display();
                        break;

                    case 2:
                        address.AddContacts();
                        address.Display();
                        break;

                    case 3:
                        address.EditContacts();
                        address.Display();
                        break;

                    case 4:
                        address.DeleteContacts();
                        address.Display();
                        break;

                    case 5:
                        address.AddMultiple();
                        address.Display();
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
        
    }
    }
}
