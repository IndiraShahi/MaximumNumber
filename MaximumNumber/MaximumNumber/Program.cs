using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to maximum number!");
            MaxNumber max = new MaxNumber();

            int[] intArray = { 1, 5, 10, 15, 20 };
            max.MaxValue<int>(intArray);

            double[] doubleArray = { 5.1, 6.2, 5.4, 6.3 };
            max.MaxValue<double>(doubleArray);

            string[] stringArray = { "5", "19", "10", "15" };
            max.MaxValue<string>(stringArray);
        }
    }
}
