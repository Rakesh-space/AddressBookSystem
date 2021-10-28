using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string keyPress = "o";
            //guide to user 
            Console.WriteLine("_Welcome to the address book program_");
            Console.WriteLine("Select the option.");
            Console.WriteLine("1- Add contact, 2- View contact,3-edit contact");

            Console.WriteLine();
            AddressBook AddObj = new AddressBook();
            num = Convert.ToInt32(Console.ReadLine());
            while (keyPress != "n")
            {
                switch (num)               //switch case 
                {
                    case 1:
                        AddObj.AddContact();
                        break;

                    case 2:
                        AddObj.View();
                        break;

                    case 3:
                        AddObj.Edit();
                        break;
                }
                Console.WriteLine("Do you wish to continue? Press (y/n)");
                keyPress = Console.ReadLine();
            }
        Console.ReadLine();
        }
    } 
}
