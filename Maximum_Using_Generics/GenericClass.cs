using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum_Using_Generics
{
    public class GenericClass<T> where T : IComparable
    {
        public T[] arr;

        public GenericClass(T[] arr)
        {
            this.arr = arr;
        }

        public T[] Sort(T[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        public T MaxValue(params T[] arr)
        {
            var sorted_arr = Sort(arr);
            return sorted_arr[sorted_arr.Length - 1];
        }

        public T MaxMethod()
        {
            return(MaxValue(this.arr));

        }

        public void PrintMax()
        {
            Console.WriteLine(MaxValue(this.arr));
        }

    }

   
}
