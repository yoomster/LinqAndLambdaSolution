﻿using LinqUI;
using System.Runtime.CompilerServices;

namespace LinqUI
{
    class Program
    {
        static void Main(string[] arg)
        {
            //LinqTests();

            LambdaTests();

            Console.WriteLine("Done processing");
            Console.ReadLine();
        }

        private static void LinqTests()
        {
            var contacts = SampleData.GetContactData();
            var addresses = SampleData.GetAddressData();
            var people = SampleData.GetPersonData();


            //var results = (from c in contacts
            //               join a in addresses
            //               on c.Id equals a.ContactId
            //               select new { c.FirstName, c.LastName, a.Address, a.HouseNr, a.City });

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} from {item.City} ");
            //}

            //one to many relation
            //var results = (from c in contacts
            //               select new { c.FirstName, c.LastName, Addresses = addresses.Where(x => x.ContactId == c.Id) });

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Addresses.Count()} addresses ");
            //}

            //many to many relation
            //var results = (from c in contacts
            //               select new { c.FirstName, c.LastName, Addresses = addresses.Where(a => c.Addresses.Contains(a.Id)) });

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Addresses.Count()} addresses ");
            //}

            var results = (from p in people
                           select new {p.FirstName, p.LastName});
            foreach (var item in results)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}");
            }
        }

        private static void LambdaTests()
        {
            var data = SampleData.GetContactData();
            var people = SampleData.GetPersonData();


            //var results = data.Where(x => x.Addresses.Count > 1);

            //foreach (var person in results)
            //{
            //    Console.WriteLine($"{person.FirstName} {person.LastName}");
            //}


            //var results = data.Select(x => x.FirstName);

            //foreach (var result in results)
            //{
            //    Console.WriteLine(result);
            //}

            //var results = data.Take(2);

            //foreach (var person in results)
            //{
            //    Console.WriteLine($"{person.FirstName} {person.LastName}");
            //}

            //var results = data.Skip(2).Take(1);

            //foreach (var person in results)
            //{
            //    Console.WriteLine($"{person.FirstName} {person.LastName}");
            //}

            //var results = data.OrderBy(x => x.LastName);

            //foreach (var person in results)
            //{
            //    Console.WriteLine($"{person.FirstName} {person.LastName}");
            //}

            var results = people.Skip(1);

            foreach (var item in results)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }
    }
}
  