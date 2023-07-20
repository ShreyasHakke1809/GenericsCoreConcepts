namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 9, 18, 27, 36, 45 };
            double[] doubleArray = { 9.99, 18, 27, 27.45, 45.54 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            int x = 9, y = 18, z= 27;
            float a = 18.27f, b = 27.18f, c = 45.63f;
            string str1 = "abc", str2 = "xyz", str3 = "pqr";
            Console.WriteLine("Welcome to Generic Programs");
            Console.WriteLine("Choose any one program from given option");
            Console.WriteLine("1.Print array without generics\n2.Print array using generics\n3.Print array using generic class\n4.FindMaxValue\n5.FindMaxValue using generic");
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
                case 4:
                    Console.WriteLine("Given input are {0} {1} {2}", x, y, z);
                    FindMaxValue.FindMax(x,y,z);
                    Console.WriteLine("Given input are {0} {1} {2}", a, b, c);
                    FindMaxValue.FindMax(a,b,c);
                    Console.WriteLine("Given input are {0} {1} {2}", str1, str2, str3);
                    FindMaxValue.FindMax(str1, str2, str3);
                    break;
                case 5:
                    FindMaxValueUsingGenerics<int> intObj = new FindMaxValueUsingGenerics<int>(x,y,z);
                    intObj.TextMaximum();
                    break;

                default:
                    Console.WriteLine("Choose number within range");
                    break;
            }


           
        }    
    }
}