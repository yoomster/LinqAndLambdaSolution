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
                new ContactModel { Id = 3, FirstName = "Snuggles", LastName = "Pants", Addresses = new List<int> { 1,2,3,4 }},
                new ContactModel { Id = 3, FirstName = "Balou", LastName = "Perenboom", Addresses = new List<int> { 1, 2,3 }}

            };
            return output;
        }

        public static List<AddressModel> GetAddressData() 
        {
            List<AddressModel> output = new List<AddressModel>
            {
                new AddressModel{Id= 1, Address ="Frits", HouseNr = 123, City = "Ehv", },
            };
            return output;
        }
    }
}
