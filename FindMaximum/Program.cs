using System;
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
            Console.WriteLine("Choose any one From Below Option");
            Console.WriteLine("1: Find Max Num\n" + "2: FindMax Using Genrics Method");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    integerfindmax.FindMaxValue(20, 30, 40);
                    integerfindmax.FindMaxValue(20.30f, 30.45f, 65.99f);
                    integerfindmax.FindMaxValue("abc", "efg", "hij");
                    break;
                case 2:
                    GenericFindMax<int>.FindMaxValue(11, 23, 30);
                    GenericFindMax<float>.FindMaxValue(32.65f, 65.98f, 99.65f);
                    GenericFindMax<string>.FindMaxValue("abc", "efg", "hij");
                    break;
                default:
                    Console.WriteLine("Please Choose the Number Within Given Range");
                    break;
            }
                 Console.ReadLine();
            
        }
    }
}
