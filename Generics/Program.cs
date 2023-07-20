namespace Generics
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
            Console.WriteLine("1.Print array without generics");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PrintArray.ToPrint(intArray);
                    PrintArray.ToPrint(doubleArray);
                    PrintArray.ToPrint(charArray);
                    break;
                default:
                    Console.WriteLine("Choose number within range");
                    break;
            }


           
        }    
    }
}