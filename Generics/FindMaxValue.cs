﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMaxValue
    {
        public static void FindMax(int first, int second, int third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                Console.WriteLine("{0} is greater", first);
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                Console.WriteLine("{0} is greater", second);
            else
                Console.WriteLine("{0} is greater", third);
        }
        public static void FindMax(float first, float second, float third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                Console.WriteLine("{0} is greater", first);
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                Console.WriteLine("{0} is greater", second);
            else
                Console.WriteLine("{0} is greater", third);
        }
        public static void FindMax(string first, string second, string third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                Console.WriteLine("{0} is greater", first);
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                Console.WriteLine("{0} is greater", second);
            else
                Console.WriteLine("{0} is greater", third);
        }

    }
}
