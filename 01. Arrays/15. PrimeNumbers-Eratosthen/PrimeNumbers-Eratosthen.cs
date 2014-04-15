/* Write a program that finds all prime numbers in the range [1...10 000 000].
   Use the sieve of Eratosthenes algorithm (find it in Wikipedia) */

using System;
using System.Text;

class PrimeNumbersEratosthen
{
    static void Main()
    {
        int[] myArray = new int[5000001];
        StringBuilder builder = new StringBuilder();

        //Initialize only the ODD numbers in the array
        for (int index = 1, j = 1; index < 5000001; index++, j += 2)
        {
            myArray[index] = j;
        }

        Console.Write(myArray[1] + " ");

        //Check to SquareRoot of 10 000 000, which is 3163 and respond to 1582 position
        for (int index = 2; index <= 1582; index++)
        {
            // Print the prime numbers from 2 to SquareRoot of 10 000 000
            if (myArray[index] != 0)
            {
                for (int j = index + 1; j < 5000001; j++)
                {
                    if (myArray[j] % myArray[index] == 0)
                    {
                        myArray[j] = 0;
                    }
                }

                Console.Write(myArray[index] + " ");
            }
        }

        // Print the rest of numbers
        for (int index = 1582; index < 5000001; index++)
        {
            if (myArray[index] != 0)
            {
                Console.Write(myArray[index] + " ");
            }
        }
    }
}
