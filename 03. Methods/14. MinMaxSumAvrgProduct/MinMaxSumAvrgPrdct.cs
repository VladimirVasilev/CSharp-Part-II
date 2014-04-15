/* Write methods to calculate minimum, maximum, average, sum and product of 
   given set of integer numbers. Use variable number of arguments. */

using System;
using System.Numerics;

class MinMaxSumAvrgPrdct
{
    static BigInteger CalculateProduct(int[] myArray)
    {
        BigInteger product = 1;
        for (int index = 0; index < myArray.Length; index++)
        {
            product *= myArray[index];
        }

        return product;
    }

    static long CalculateSum(int[] myArray)
    {
        long sum = 0;
        for (int index = 0; index < myArray.Length; index++)
        {
            sum += myArray[index];
        }

        return sum;
    }

    static double CalculateAverageValue(int[] myArray)
    {
        double average = 0;
        for (int index = 0; index < myArray.Length; index++)
        {
            average += myArray[index];
        }

        average /= myArray.Length;
        return average;
    }

    static int CalculateMaxValue(int[] myArray)
    {
        int max = int.MinValue;
        for (int index = 0; index < myArray.Length; index++)
        {
            if (myArray[index] > max)
            {
                max = myArray[index];
            }
        }

        return max;
    }

    static int CalculateMinValue(int[] myArray)
    {
        int min = int.MaxValue;
        for (int index = 0; index < myArray.Length; index++)
        {
            if (myArray[index] < min)
            {
                min = myArray[index];
            }
        }

        return min;
    }

    static void Main()
    {
        int[] myArray = new int[] { 11, 3, 5, 2, -2, 1, 2, 2, 7, 10, 5, 7, 9, 37, 14, 69, 57, 75, 575, 1, 2, 4, 3 };

        Console.WriteLine("Minimum value: {0} \nMaximum value: {1} \nAverage value: {2} \nThe Sum is: {3} \nThe Product is: {4}",
            CalculateMinValue(myArray), CalculateMaxValue(myArray), CalculateAverageValue(myArray), CalculateSum(myArray), CalculateProduct(myArray));
    }
}
