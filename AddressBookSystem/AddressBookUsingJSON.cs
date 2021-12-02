using AddressBookSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookUsingJson
    {

        public static void JsonSerializeAddressBook(LinkedList<ContactList> addressBook)
        {
            string jsonPath = @"C:\Users\admin\source\repos\AddressBookSystem\AddressBookSystem\File\JsonFile.json";
            //contact contact = new contact() { Id = 11, firstName = "shweta", lastName = "mhetre" };
            //ContactList contact = new ContactList();
            // AddressBookClass book = new AddressBookClass();
            // LinkedList<ContactList> addressBook = new LinkedList<ContactList>();
            string result = JsonConvert.SerializeObject(addressBook);

            File.WriteAllText(jsonPath, result);
        }

        public static void JsonDeserializeAddressBook()
        {
            try
            {
                string path = @"C:\Users\admin\source\repos\AddressBookSystem\AddressBookSystem\File\jsonFile.json";
                string result = File.ReadAllText(path);

                ContactList res = JsonConvert.DeserializeObject<ContactList>(result);
                // LinkedList<ContactList> res = JsonConvert.DeserializeObject<LinkedList<ContactList>>(result);

                if (res != null)
                {
                    Console.WriteLine("contact details Using Deserialise Method");
                    Console.WriteLine("FirstName={0}\tLastName={1}\tAddress={2}\tState={3}\tZipcode={4}\tPhoneNumber={5}\tEmail={6}", res.firstName, res.lastName, res.address, res.state, res.zipCode, res.phoneNumber, res.email);

                }
                else
                {
                    Console.WriteLine("no contact");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}