using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum_Using_Generics
{
        public class FindMaximum 
        {
            public int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
            {
                try
                {
                    if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                    {
                        return firstValue;
                    }
                    if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                    {
                        return secondValue;
                    }
                    if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                    {
                        return thirdValue;
                    }
                    else
                    {
                        throw new Exception("firstNumber,secondNumber and thirdNumber are same");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return -1;
                }
            }

        public float MaximumFloatNumber(float firstValue, float secondValue, float thirdValue)
        {
            try
            {
                if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                {
                    return firstValue;
                }
                if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                {
                    return secondValue;
                }
                if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                {
                    return thirdValue;
                }
                else
                {
                    throw new Exception("firstNumber,secondNumber and thirdNumber are same");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public string MaximumStringNumber(string firstValue, string secondValue, string thirdValue)
        {
            try
            {
                if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                {
                    return firstValue;
                }
                if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                {
                    return secondValue;
                }
                if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                {
                    return thirdValue;
                }
                else
                {
                    throw new Exception("firstNumber,secondNumber and thirdNumber are same");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }

}



