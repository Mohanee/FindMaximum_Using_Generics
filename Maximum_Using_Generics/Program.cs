using System;

namespace Maximum_Using_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Find Maximum Program");
            Console.WriteLine("enter the numbers");
            float a = float.Parse((Console.ReadLine()));
            float b = float.Parse((Console.ReadLine())); 
            float c = float.Parse((Console.ReadLine()));
            FindMaximum f = new FindMaximum();
            Console.WriteLine("maximum of 3 numbers is: " + f.MaximumFloatNumber(a, b, c));

        }
    }
}
