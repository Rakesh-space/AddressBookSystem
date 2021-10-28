using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactList contact = new ContactList();
            contact.firstName = "Rakesh";
            contact.lastName = "Musale";
            contact.phoneNumber = "8007078569";
            contact.address = "Pune";
            contact.state = "Maharashtra";
            contact.email = "rakeshmusale111@gmail.com";
            contact.city = "Pune";
            contact.zip = "411013";

            Console.WriteLine("\n First Name: {0} \n Last Name: {1} \n Address: {2} \n Phone Number: {3}\n Email: {4} \n City: {5} \n State: {6}\n ZipCode: {7}", contact.firstName, contact.lastName, contact.address, contact.phoneNumber, contact.email, contact.city, contact.state, contact.zip);
            Console.ReadLine();
        }
    }
}
