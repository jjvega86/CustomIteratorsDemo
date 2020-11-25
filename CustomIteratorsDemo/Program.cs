using System;
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
            ErbiumRoster erbium = new ErbiumRoster();
            erbium.ClassMembers = new string[] { "Denis", "Greg", "Joe", "Pa", "Zack B", "Zach I", "JJ" };


            foreach (string erbiumite in erbium)
            {
                Console.WriteLine(erbiumite);

            }

            // this code does the same thing as a foreach loop
            // it accomplishes this through methods and properties inherited from IEnumerable
            var enumerator = erbium.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine($"And a second time: {enumerator.Current}");
            }

            Console.ReadLine();
        }
    }
}
