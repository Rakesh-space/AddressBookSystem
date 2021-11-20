using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
    {
        //declaring a list with the class Contacts.
        public static List<ContactList> contacts1 = new List<ContactList>();
        //declaring dictionary with the already declared list inside of it as the value pair
        public static Dictionary<string, List<ContactList>> addressBook = new Dictionary<string, List<ContactList>>();
        //declaring it static so that we dont need to create an object in the program.cs

        public static void AddTo(string name)              //this method is used to pass the new address book name to the dictionary
        {
            addressBook.Add(name, contacts1);
        }
        public void AddContact()
        {
            Console.WriteLine("\nEnter Name of address book to add new contact");
            string name = Console.ReadLine();
            //checking, if the name is existing in the dictionary
            if (!addressBook.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
                Console.WriteLine("Please Enter Valid Name from following names:");
                //displaying the available dictionary names
                foreach (KeyValuePair<string, List<ContactList>> tempPair in addressBook)
                {
                    Console.WriteLine(tempPair.Key);
                }
            }
            else
            {
                ContactList contactList = new ContactList();  //here create a ContactList object
                contacts1.Add(contactList);  //here contactlist object adding to dictionary
            }
        }
        public void View()  //here Display the data by using Dictionary
        {
            Console.WriteLine("Here is the list and details of all the contacts in your addressbook.");
            foreach (KeyValuePair<string, List<ContactList>> kv in addressBook)  //this foreacch loops iterates through all the contacts objects in the contacts class
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
        public void Edit()        //this method lets the user edit the details based on their firstname
        {
            Console.WriteLine("\nEnter Name of address book to modify contact details");
            string name = Console.ReadLine();
            //checking if the name exist in dictionary
            if (!addressBook.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
                Console.WriteLine("Please Enter Valid Name from following names:");
                //displaying the names that are available in dictionary
                foreach (KeyValuePair<string, List<ContactList>> tempPair in addressBook)
                {
                    Console.WriteLine(tempPair.Key);
                }
            }
            else
            {
                ContactList contactList = new ContactList();  //here create a ContactList object
                contacts1.Add(contactList);  //here contactlist object adding to dictionary
            }
        }


        public void Delete(Dictionary<string, List<ContactList>> addressBook, List<ContactList> contacts1)
        {

            Console.WriteLine("\nEnter Name of address book to delete contact details");
            string name = Console.ReadLine();
            if (!addressBook.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
                Console.WriteLine("Please Enter Valid Name from following names:");

                foreach (KeyValuePair<string, List<ContactList>> tempPair in addressBook)
                {
                    Console.WriteLine(tempPair.Key);
                }
            }
            else
            {
                ContactList contactList = new ContactList();  //here create a ContactList object
                contacts1.Add(contactList);  //here contactlist object adding to dictionary
            }
        }

        public static ContactList Equals(List<ContactList> list, String name) //here find out dublicate entry by using equals method
        {
            try
            {
                Console.WriteLine("\n here Findout the Dublicate Entry");
                var contactObj = list.Find(p => p.firstName == name);  //here use lamda concepts

                if (contactObj != null)
                {
                    Console.WriteLine("\n Dublicate is Present:", contactObj.firstName);
                    return contactObj;
                }
                else
                {
                    Console.WriteLine("\n Dublicate is Not present.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static ContactList SearchName(List<ContactList> list, String name)  //here find out 
        {
            var contObj = list.Find(p => p.firstName == name); //here use lamda concepts

            try
            {
                if (contObj != null)
                {
                    Console.WriteLine("\n Present :", contObj.firstName);
                    return contObj;
                }
                else
                {
                    Console.WriteLine("\n Not Present.");
                    return contObj;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        // Searching by city for address book and contact details
      
        public void SearchingByCity()
        {
            try
            {
                Console.WriteLine("Please enter the city");
                string searchCity = Console.ReadLine();
                //foreach loop to print name of address book and pass address book value to contact person information class
                foreach (KeyValuePair<string, List<ContactList>> keyValuePair in addressBook)
                {
                    foreach (KeyValuePair<string, List<ContactList>> tempPair in addressBook)
                    {
                        Console.WriteLine(tempPair.Value);
                    }
                }
            }
            //catches exception if city name does not exist
            catch (AddressBookCustomException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Do you want to enter city again, press y for yes");
                string checkInput = Console.ReadLine();
                if (checkInput.ToLower() == "y")
                {
                    SearchingByCity();  //here recursive calling
                }
                else
                {
                    Console.WriteLine("No city entered");

                }
            }
        }

        // Searching by state to get address book and contact details
      
        public void SearchingByState()
        {
            //used to find custom exception, if state do not exist
            try
            {
                Console.WriteLine("Please enter the state");
                string searchState = Console.ReadLine();
                //foreach loop is used to print key for dictionary and pass the values of dictionary to contact person information class
                foreach (KeyValuePair<string, List<ContactList>> keyValuePair in addressBook)
                {
                    foreach (KeyValuePair<string, List<ContactList>> tempPair in addressBook)
                    {
                        Console.WriteLine(tempPair.Value);
                    }
                }
            }
            catch (AddressBookCustomException ex)
            {
                //Exception message
                Console.WriteLine(ex.Message);
                Console.WriteLine("Do you want to enter state again, press y for yes");
                string checkInput = Console.ReadLine();
                if (checkInput.ToLower() == "y")
                {
                    //Details of state are entered again.
                    SearchingByState();
                }
                else
                {
                    Console.WriteLine("No state entered");

                }
            }
        }
    }
}
