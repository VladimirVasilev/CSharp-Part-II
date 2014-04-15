using System;

class PrintMatrix
{
    static void Main()
    {
        //Input
        Console.Write("Size of the matrix will be: ");
        int size = int.Parse(Console.ReadLine());

        int[,] myArray = new int[size, size]; //Allocate our matrix with given size

        //Main logic and initialize array elements about condition a):
        int elementValue = 1;
        for (int col = 0; col < myArray.GetLength(1); col++)
        {
            for (int row = 0; row < myArray.GetLength(0); row++)
            {
                myArray[row, col] = elementValue;
                elementValue++;
            }
        }

        //Output - a)
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("a)");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        MatrixPrint(myArray);

        //Main logic and initialize array elements about condition b):
        elementValue = 1; //Reset value of the variable to its initial state
        for (int col = 0; col < myArray.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < myArray.GetLength(0); row++)
                {
                    myArray[row, col] = elementValue;
                    elementValue++;
                }
            }
            else
            {
                for (int row = myArray.GetLength(0) - 1; row >= 0; row--)
                {
                    myArray[row, col] = elementValue;
                    elementValue++;
                }
            }
        }

        //Output - b)
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("b)");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        MatrixPrint(myArray);

        //Main logic and initialize array elements about condition c):
        elementValue = 1; //Reset value of the variable to its initial state
        for (int row = myArray.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col < myArray.GetLength(1) - row; col++)
            {
                myArray[row + col, col] = elementValue++;
            }
        }

        for (int col = 1; col < myArray.GetLength(1); col++)
        {
            for (int row = 0; row < myArray.GetLength(0) - col; row++)
            {
                myArray[row, col + row] = elementValue++;
            }
        }

        //Output - c)
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("c)");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        MatrixPrint(myArray);
    }
    
    private static void MatrixPrint(int[,] myArray)
    {
        for (int row = 0; row < myArray.GetLength(0); row++)
        {
            for (int col = 0; col < myArray.GetLength(1); col++)
            {
                Console.Write("{0,4}", myArray[row, col]);
            }

            Console.WriteLine();
        }
    }
}
