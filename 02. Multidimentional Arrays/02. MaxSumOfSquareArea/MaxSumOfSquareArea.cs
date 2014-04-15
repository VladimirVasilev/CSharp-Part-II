/* Write a program that reads a rectangular matrix of size N x M and
   finds in it the square 3 x 3 that has maximal sum of its elements. */

using System;

class MaxSumOfSquareArea
{
    static void Main()
    {
        //Input
        Console.WriteLine("Please set a values for the matrix sizes \"array[N, M]\"");
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int m = int.Parse(Console.ReadLine());

        if (n >= 3 && m >= 3)
        {


            int[,] myArray = new int[n, m]; //Allocate our matrix with the given sizes

            //Hardcoded test input array
            //int[,] myArray =
            //    {
            //        { 1, 1, 1, 1 },
            //        { 1, 1, 1, 1 },
            //        { 1, 1, 1, 1 },
            //        { 1, 1, 1, 1 },
            //        { 1, 1, 9, 1 },
            //        { 1, 1, 1, 1 }
            //    };        

            //Initialize array elements
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int row = 0; row < myArray.GetLength(0); row++)
            {
                for (int col = 0; col < myArray.GetLength(1); col++)
                {
                    Console.Write("myArray[{0}, {1}] = ", row, col);
                    string inputNum = Console.ReadLine();
                    myArray[row, col] = int.Parse(inputNum);
                }
            }

            //Print matrix
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Your array is:");
            for (int row = 0; row < myArray.GetLength(0); row++)
            {
                for (int col = 0; col < myArray.GetLength(1); col++)
                {
                    Console.Write("{0, 5}", myArray[row, col]);
                }

                Console.WriteLine();
            }

            //Main logic
            int tempSum = 0;
            int maxSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < myArray.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < myArray.GetLength(1) - 2; col++)
                {
                    tempSum += myArray[row, col] + myArray[row, col + 1] + myArray[row, col + 2] +
                        myArray[row + 1, col] + myArray[row + 1, col + 1] + myArray[row + 1, col + 2] +
                        myArray[row + 2, col] + myArray[row + 2, col + 1] + myArray[row + 2, col + 2];

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        bestRow = row;
                        bestCol = col;
                    }

                    tempSum = 0;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Best area with size 3x3 is with sum: {0}", maxSum);
            for (int row = bestRow; row < bestRow + 3; row++)
            {
                for (int col = bestCol; col < bestCol + 3; col++)
                {
                    Console.Write("{0, 5}", myArray[row, col]);
                }

                Console.WriteLine();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error! N and M should be bigger than 3. \n Please try again!");
        }
    }
}
