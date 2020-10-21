using System;

namespace Maximum_Using_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Find Maximum Program");
            Console.WriteLine("enter the numbers");
            string a = Console.ReadLine();
            string b = Console.ReadLine(); 
            string c = Console.ReadLine();
            FindMaximum f = new FindMaximum();
            Console.WriteLine("maximum of 3 numbers is: " + f.MaximumStringNumber(a, b, c));

        }
    }
}
