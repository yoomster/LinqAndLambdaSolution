using LinqUI;
using System.Runtime.CompilerServices;

namespace LinqUI
{
    class Program
    {
        static void Main(string[] arg)
        {
            LinqTests();

            //LambdaTests();

            Console.WriteLine("Done processing");
            Console.ReadLine();
        }

        private static void LinqTests()
        {
            var contacts = SampleData.GetContactData();
            var addresses = SampleData.GetAddressData();

            var results = (from c in contacts
                           join a in addresses
                           on c.Id equals a.ContactId
                           select new { c.FirstName, c.LastName, a.Address, a.HouseNr, a.City });

            foreach (var item in results)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} from {item.City} ");
            }
        }
        private static void LambdaTests()
        {
            var data = SampleData.GetContactData();

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

            var results = data.OrderBy(x => x.LastName);

            foreach (var person in results)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
        }
    }
}
