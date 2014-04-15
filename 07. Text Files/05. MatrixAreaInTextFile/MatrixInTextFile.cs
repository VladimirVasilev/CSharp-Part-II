/* Write a program that reads a text file containing a square matrix of numbers and finds
   in the matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in
   the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space.
   The output should be a single number in a separate text file. Example:
    4
    2 3 3 4
    0 2 3 4  -->  17
    3 7 1 2
    4 3 3 2
 */

using System;
using System.IO;
using System.Threading;

class MatrixInTextFile
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader("../../MatrixTextFile.txt");
        using (inputFile)
        {
            int size = int.Parse(inputFile.ReadLine());
            int[,] matrix = new int[size, size];

            string line;
            int matrixLine = 0;
            while ((line = inputFile.ReadLine()) != null)
            {
                string[] num = line.Split(' ');
                for (int index = 0; index < num.Length; index++)
                {
                    matrix[matrixLine, index] = int.Parse(num[index]);
                }

                matrixLine++;
            }

            int maxSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }

            using (StreamWriter outputFile = new StreamWriter("../../OutputMaxSum.txt"))
            {
                outputFile.WriteLine(maxSum);
            }
        }

        //Simulating Loading Phase
        Console.Write("Processing");
        for (int i = 0; i < 21; i++)
        {
            Console.Write(".");
            Thread.Sleep(150);
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("DONE!");
    }
}
