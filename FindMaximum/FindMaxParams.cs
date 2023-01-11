using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class FindMaxParams
    {
        public static void MaxValue(params int[] values)
        {
            Array.Sort(values);
            Console.WriteLine("Maximum values : " + values[values.Length - 1]);
        }
    }
}
