using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBookFileOperations
    {


        /// <summary>
        /// Writes the address book using stream writer.
        /// UC13
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="email">The email.</param>
        public static void WriteAddressBookUsingStreamWriter(string firstName, string lastName, string[] address, string state, int zipCode, long phoneNumber, string email)
        {
            string path = @"C:\Users\admin\source\repos\AddressBookSystem\AddressBookSystem\File\AddressBookWriteFile.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine(firstName + " " + lastName + " " + address + " " + state + " " + zipCode + " " + phoneNumber + " " + email);
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));

            }


        }

        /// <summary>
        /// Reads the address book using stream reader.
        /// UC13
        /// </summary>
        public static void ReadAddressBookUsingStreamReader()
        {
            Console.WriteLine("the contatc List using StreamReader method ");

            string path = @"C:\Users\admin\source\repos\AddressBookSystem\AddressBoo\AddressBookWriteFile.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = " ";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }

            }
        }

    }
}
