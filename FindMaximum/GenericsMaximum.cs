using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class GenericsMaximum<T> where T : IComparable
    {
        public T[] value;
        public GenericsMaximum(T[] value)
        {
            this.value = value;
        }
        public T[] Sorting(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
             var sortedValues = Sorting(value);
             return sortedValues[sortedValues.Length - 1];
        }
        public void PrintMaxValues()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum values is " + max);
        }
    }
}
    
        

    
    

