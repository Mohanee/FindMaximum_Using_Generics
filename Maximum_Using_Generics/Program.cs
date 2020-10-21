using System;

namespace Maximum_Using_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Find Maximum Program");
            Console.WriteLine("1.INT\t 2.FLOAT\t 3.STRING");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k == 1)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
             //   FindMaximum f = new FindMaximum();
               // Console.WriteLine("maximum of 3 is: "+ f.Maximum<int>(a, b, c));


                GenericClass<int> gInt = new GenericClass<int>(a,b,c);
                gInt.PrintMax();
            }

            if (k == 2)
            {
                float a = float.Parse(Console.ReadLine());
                float b = float.Parse(Console.ReadLine());
                float c = float.Parse(Console.ReadLine());
                // FindMaximum f = new FindMaximum();
                //Console.WriteLine("maximum of 3 is: " + f.Maximum<float>(a, b, c));

                GenericClass<float> gFloat = new GenericClass<float>(a, b, c);
                gFloat.PrintMax();

            }

            if (k == 3)
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string c = Console.ReadLine();
                //FindMaximum f = new FindMaximum();
                //Console.WriteLine("maximum of 3 is: "+ f.Maximum<string>(a, b, c));


                GenericClass<string> gString = new GenericClass<string>(a, b, c);
                gString.PrintMax();
            }



        }
    }
}
