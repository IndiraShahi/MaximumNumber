using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to maximum number!");
            MaxNumber max = new MaxNumber();
            Console.WriteLine(max.Max<int>(20, 40, 30));
            Console.WriteLine(max.Max<float>(5.1f, 6.5f, 5.5f));
            Console.WriteLine(max.Max<string>("Apple", "Peach", "Banana"));
        }
    }
}
