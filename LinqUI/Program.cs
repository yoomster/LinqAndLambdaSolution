using LinqUI;
using System.Runtime.CompilerServices;

namespace LinqUI
{
    class Program
    {
        static void Main(string[] arg)
        {
            LambdaTests();

            Console.WriteLine("Done processing");
            Console.ReadLine();
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

            var results = data.Skip(2).Take(1);

            foreach (var person in results)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
        }
    }
}