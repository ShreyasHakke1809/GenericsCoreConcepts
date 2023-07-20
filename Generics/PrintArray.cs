using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintArray
    {
        public static void ToPrint(int[] arr)
        {
            Console.WriteLine("\nInteger array elements");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
        }
        public static void ToPrint(double[] arr)
        {
            Console.WriteLine("\nDouble array elements");
            foreach (double element in arr)
            {
                Console.Write(element + " ");
            }
        }
        public static void ToPrint(char[] arr)
        {
            Console.WriteLine("\nChar array elements");
            foreach (char element in arr)
            {
                Console.Write(element + " ");
            }
        }
    }
}
