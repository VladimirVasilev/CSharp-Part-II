/* Write a program that allocates array of 20 integers and initializes each 
  element by its index multiplied by 5. Print the obtained array on the console. */

using System;

class IndexMultipleBy5
{
    static void Main()
    {
        int[] myArr = new int[20];

        for (int index = 0; index < myArr.Length; index++)
        {
            myArr[index] = index * 5;
            Console.Write("{0,3}", myArr[index]);
        }

        Console.WriteLine();
    }
}
