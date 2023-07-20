﻿namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 9, 18, 27, 36, 45 };
            double[] doubleArray = { 9.99, 18, 27, 27.45, 45.54 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            Console.WriteLine("Welcome to Generic Programs");
            Console.WriteLine("Choose any one program from given option");
            Console.WriteLine("1.Print array without generics\n2.Print array using generics\n3.Print array using generic class");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PrintArray.ToPrint(intArray);
                    PrintArray.ToPrint(doubleArray);
                    PrintArray.ToPrint(charArray);
                    break;
                case 2:
                    PrintArrayUsingGenerics.ToPrint<int>(intArray);
                    PrintArrayUsingGenerics.ToPrint<double>(doubleArray);
                    PrintArrayUsingGenerics.ToPrint<char>(charArray);
                    break;
                case 3:
                    PrintArrayUsingGenericClass<int> intObject = new PrintArrayUsingGenericClass<int>(intArray);
                    intObject.ToPrint();
                    PrintArrayUsingGenericClass<double> doubleObject = new PrintArrayUsingGenericClass<double>(doubleArray);
                    doubleObject.ToPrint();
                    break;

                default:
                    Console.WriteLine("Choose number within range");
                    break;
            }


           
        }    
    }
}