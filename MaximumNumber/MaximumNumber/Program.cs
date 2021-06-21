using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to maximum number!");
            MaximumInteger max = new MaximumInteger();
            int maxNumberOne = max.MaxInteger(100, 80, 90);
            Console.WriteLine(maxNumberOne + " is maximum");

            int maxNumberTwo = max.MaxInteger(50, 60, 40);
            Console.WriteLine(maxNumberTwo + " is maximum");

            int maxNumberThree = max.MaxInteger(60, 50, 100);
            Console.WriteLine(maxNumberThree + " is maximum"); 
            
            float floatMaxOne = max.MaxFloat(5.6f, 4.6f, 3.6f);
            Console.WriteLine(floatMaxOne + " is maximum");

            float floatMaxTwo = max.MaxFloat(3.6f, 5.6f, 4.6f);
            Console.WriteLine(floatMaxTwo + " is maximum");

            float floatMaxThree = max.MaxFloat(3.6f, 4.6f, 5.6f);
            Console.WriteLine(floatMaxThree + " is maximum");
        }
    }
}
