﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Genrics use cases");
            integerfindmax.FindMaxValue(20, 30, 40);
            integerfindmax.FindMaxValue(20.30f, 30.45f, 65.99f);
            integerfindmax.FindMaxValue("abc", "efg", "hij");
            Console.ReadLine();
        }
    }
}
