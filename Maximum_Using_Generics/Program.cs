using System;

namespace Maximum_Using_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Find Maximum Program");
            Console.WriteLine("enter the numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            FindMaximum f = new FindMaximum();
            Console.WriteLine("maximum of 3 numbers is: " + f.MaximumIntegerNumber(a, b, c));

        }
    }
}
