using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum_Using_Generics
{
    public class GenericClass<T> where T : IComparable
    {
        public T a, b, c;

        public GenericClass(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public T Maximum()
        {
            if (this.a.CompareTo(this.b) > 0 && this.a.CompareTo(this.c) > 0)
            {
                return (this.a);
            }
            if (this.b.CompareTo(this.a) > 0 && this.b.CompareTo(this.c) > 0)
            {
                return (this.b);
            }
            if (this.c.CompareTo(this.a) > 0 && this.c.CompareTo(this.b) > 0)
            {
                return (this.c);
            }
            else
            {
                throw new Exception("firstNumber,secondNumber and thirdNumber are same");
            }

        }

        public void PrintMax()
        {
            Console.WriteLine(Maximum());
        }

    }

   
}
