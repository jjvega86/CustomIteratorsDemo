﻿using System;
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

            foreach (string erbiumite in erbium)
            {
                Console.WriteLine(erbiumite);

            }

            Console.ReadLine();
        }
    }
}
