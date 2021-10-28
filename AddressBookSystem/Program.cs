using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            //guide to user 
            Console.WriteLine("_Welcome to the address book program_");
            Console.WriteLine();
            Console.WriteLine("Select the option.");
            Console.WriteLine("1- Add contact, 2- View contact");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (num)               //switch case 
            {
                case 1:
                    AddressBook AddObj = new AddressBook();
                    AddObj.AddContact();
                    AddObj.View();
                    break;

                case 2:
                    AddressBook Addobj2 = new AddressBook();
                    Addobj2.View();
                    break;
            }
            Console.ReadLine();
        }
    } 
}
