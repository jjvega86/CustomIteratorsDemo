using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIteratorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> exampleList = new List<string>();

            ErbiumRoster erbium = new ErbiumRoster(); // this is an instance of the ErbiumRoster class, which is a custom type we treat as a collection
            erbium.ClassMembers = new string[] { "Denis", "Greg", "Joe", "Pa", "Zack B", "Zach I"};
            // what happens if I add or subtract class members?


            foreach (string erbiumite in erbium) // why can't we use a foreach loop for any collection we want to?
            {
                Console.WriteLine(erbiumite);

            }

            Console.WriteLine("");


            // this code does the same thing as a foreach loop
            // it accomplishes this through methods and properties inherited from IEnumerable
            IEnumerator enumerator = erbium.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine($"And a second time: {enumerator.Current}");
            }

            Console.ReadLine();
        }
    }
}
