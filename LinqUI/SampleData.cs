using LinqUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUI
{
    public class SampleData
    {
        public static List<ContactModel> GetContactData()
        {
            List<ContactModel> output = new List<ContactModel>
            {
                new ContactModel { Id = 1, FirstName = "Naomi", LastName = "Perenboom", Addresses = new List<int> { 1, 2, 3 }},
                new ContactModel { Id = 2, FirstName = "Adam", LastName = "Akil", Addresses = new List<int> { 1 }},
                new ContactModel { Id = 3, FirstName = "Teddy", LastName = "Saurus", Addresses = new List<int> { 1, 2 }},
                new ContactModel { Id = 4, FirstName = "Snuggles", LastName = "Pants", Addresses = new List<int> { 1 }},
                new ContactModel { Id = 5, FirstName = "Balou", LastName = "Perenboom", Addresses = new List<int> { 1 }}

            };
            return output;
        }

        public static List<AddressModel> GetAddressData() 
        {
            List<AddressModel> output = new List<AddressModel>
            {
                new AddressModel{Id= 1, ContactId = 1, Address ="Frits", HouseNr = 104, City = "Ehv", },
                new AddressModel{Id= 2, ContactId = 1, Address ="Frederik", HouseNr = 189, City = "Ehv", },
                new AddressModel{Id= 3, ContactId = 2, Address ="Frederik", HouseNr = 104, City = "Hm", },
                new AddressModel{Id= 4, ContactId = 2, Address ="Frits", HouseNr = 104, City = "Ehv", },
                new AddressModel{Id= 5, ContactId = 3, Address ="Frits", HouseNr = 104, City = "Ehv", },
                new AddressModel{Id= 6, ContactId = 4, Address ="Frederik", HouseNr = 189, City = "Ehv", },
                new AddressModel{Id= 7, ContactId = 5, Address ="Hoppie", HouseNr = 3, City = "Hm", }
            };
            return output;
        }
    }
}
