using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintArrayUsingGenerics
    {
        public static void ToPrint<T>(T[]arr)
        {
            Console.WriteLine("\nArray element");
            foreach (T element in arr)
            {
                Console.Write(element+ " ");
            }
        }
    }
}
