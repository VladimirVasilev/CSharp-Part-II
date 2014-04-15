/* * Modify your last program and try to make it work for any number type, not just integer
   (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#). */

using System;
using System.Collections.Generic;
using System.Numerics;

class UseGenericMethods
{
    static T CalculateProduct<T>(T[] myArray)
    {
        dynamic product = 1;
        for (int index = 0; index < myArray.Length; index++)
        {
            product *= myArray[index];
        }

        return product;
    }

    static T CalculateSum<T>(T[] myArray)
    {
        dynamic sum = 0;
        for (int index = 0; index < myArray.Length; index++)
        {
            sum += myArray[index];
        }

        return sum;
    }

    static T CalculateAverageValue<T>(T[] myArray)
    {
        dynamic average = 0;
        for (int index = 0; index < myArray.Length; index++)
        {
            average += myArray[index];
        }

        average /= myArray.Length;
        return average;
    }

    static T CalculateMaxValue<T>(T[] myArray)
    {
        dynamic max = int.MinValue;
        for (int index = 0; index < myArray.Length; index++)
        {
            if (myArray[index] > max)
            {
                max = myArray[index];
            }
        }

        return max;
    }

    static T CalculateMinValue<T>(T[] myArray)
    {
        dynamic min = int.MaxValue;
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
        int[] myArray = new int[] { 7, 3, 5, -2, 1, 17, 12, 6 };

        Console.WriteLine("Minimum value: {0} \nMaximum value: {1} \nAverage value: {2} \nThe Sum is: {3} \nThe Product is: {4}",
            CalculateMinValue(myArray), CalculateMaxValue(myArray), CalculateAverageValue(myArray), CalculateSum(myArray), CalculateProduct(myArray));
    }
}
