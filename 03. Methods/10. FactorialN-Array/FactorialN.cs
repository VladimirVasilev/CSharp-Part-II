/* Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method 
   that multiplies a number represented as array of digits by given integer number. */

using System;
using System.Numerics;

class FactorialN
{
    public static BigInteger Factorial(int i)
    {
        BigInteger factor = i;
        while (i > 0)
        {
            factor *= i;
            i--;
        }

        return factor;
    }

    public static void CalcFactorialN(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            BigInteger factorial = Factorial(i);
            Console.WriteLine(factorial);
        }
    }    

    static void Main()
    {
        int[] myArray = new int[100];

        for (int index = 0; index < myArray.Length; index++)
        {
            myArray[index] = index + 1;
        }

        CalcFactorialN(myArray);
    }   
}
