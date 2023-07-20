using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintArrayUsingGenericClass<T>
    {
        public T[] arry;
        public PrintArrayUsingGenericClass(T[] arry)
        {
            this.arry = arry;
        }
        public void ToPrint()
        {
            Console.WriteLine("\nArray elements");
            foreach (var element in arry)
            {
                Console.Write(element + " ");
            }
        }
    }
}
