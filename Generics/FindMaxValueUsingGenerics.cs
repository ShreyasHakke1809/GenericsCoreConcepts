using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMaxValueUsingGenerics<T> where T :IComparable
    {
        public T first, second, third;

        public FindMaxValueUsingGenerics(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        private static T FindMax(T first, T second, T third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is greater", first);
                return first;
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is greater", second);
                return second;
            }
            else
            {
                Console.WriteLine("{0} is greater", third);
                return third;
            }
        }
        public void TextMaximum()
        {
            T maxValue = FindMax(first, second, third);
            Console.WriteLine("Max value is " + maxValue);
        }
    }
}
