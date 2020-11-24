using System;

namespace _02.usingMethods
{
    class Program
    {
        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative .", number);
            }
            else
            {
                Console.WriteLine("The numebr {0} is zero.", number);
            }
        }


        static void PrintMax(float number1, float number2)
        {
            float max = number1;
            if (number2 > number1)
            {
                max = number2;
            }
            Console.WriteLine("Maximal  number :{0}", max);
        }

        static void MakeNumberPositive(int? number) //ref--refers to an addres-pointer into the momory
        {
            if (number < 0)
            {
                number = -number; //We reinitialize the same numbber with minus sign in front
                                  //i e, as the number is negative then we make it positive : -(-) = +;

            }
            Console.WriteLine(number);
        }
        static void ChangeArray(int[] arr)
        {
            arr = new int[] { 42, 69, 108 }
        }


        static void Main()
        {
            int[] arr = new int[] { 1, 2, 3 };
            foreach  (int item in arr)
            {
                Console.WriteLine(arr(item));
            }
            ChangeArray(arr);
        }

    }
}
