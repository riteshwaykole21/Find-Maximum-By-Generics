using FindMaximum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsUCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Use Case's ");
            Console.WriteLine("Choose any one from below options");
            Console.WriteLine("1:Find Max Num\n" +
                "2:FindMax using Generic Method\n" +
                "3:FindMax using Generic Class \n" +
                "4 : Param Concept-takes any no of parameter");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    integerfindmax.FindMaxValue(20, 30, 40);                   //UC1 finding max out of 3 int.
                    integerfindmax.FindMaxValue(20.45f, 30.11f, 12.99f);
                    integerfindmax.FindMaxValue("abc", "def", "ghi");       //UC3 finding max out of 3 string.

                    break;
                case 2:
                    FindMaxGenericMethod<int>.FindMaxValue(11, 23, 30);       //find max using generic method
                    FindMaxGenericMethod<float>.FindMaxValue(20.45f, 30.11f, 12.99f);       //find max using generic method
                    FindMaxGenericMethod<string>.FindMaxValue("abc", "def", "ghi");       //find max using generic method
                    break;
                case 3:
                    //FindMaxGenericClass<int> genericObj1 = new FindMaxGenericClass<int>(20, 30, 12);
                    //genericObj1.TestMaximum();
                    new FindMaxGenericClass<int>(20, 30, 12).TestMaximum();                   //find max using generic class .
                    new FindMaxGenericClass<float>(20.45f, 30.11f, 12.99f).TestMaximum();
                    new FindMaxGenericClass<string>("abc", "def", "ghi").TestMaximum();
                    break;
                case 4:
                    FindMaxParams.MaxValue(99, 23, 6, 23, 43); //using Parameter sample 1
                    FindMaxParams.MaxValue(65, 6, 23, 43);  //using parameter sample 2
                    break;
                default:
                    Console.WriteLine("Please choose number within given range!");
                    break;
            }
            Console.ReadLine();
        }
    }
}