using System;

class LongestSequenceOfEqualStrings
{
    static void Main()
    {
        //Input
        //Console.WriteLine("Please set a values for the matrix sizes \"array[N, M]\"");
        //Console.Write("N = ");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("M = ");
        //int m = int.Parse(Console.ReadLine());

        //string[,] myArray = new string[n, m]; //Allocate our matrix with the given sizes

        //Hardcoded test input array
        string[,] myArray =
            {
                { "ho", "fifi", "ho", "hi" },
                { "ha", "ha", "hi", "xx" },
                { "xxx", "ho", "ha", "xx" },
            };        

        ////Initialize array elements
        //Console.ForegroundColor = ConsoleColor.DarkCyan;
        //for (int row = 0; row < myArray.GetLength(0); row++)
        //{
        //    for (int col = 0; col < myArray.GetLength(1); col++)
        //    {
        //        Console.Write("myArray[{0}, {1}] = ", row, col);
        //        string input = Console.ReadLine();
        //        myArray[row, col] = input;
        //    }
        //}

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
        int bestLen = 1;
        int tempLen = 1;
        string bestElement = String.Empty;

        //Horizontal check
        for (int row = 0; row < myArray.GetLength(0); row++)
        {
            for (int col = 0; col < myArray.GetLength(1) - 1; col++)
            {
                if (myArray[row, col] == myArray[row, col + 1])
                {
                    tempLen++;
                    if (tempLen > bestLen)
                    {
                        bestLen = tempLen;
                        bestElement = myArray[row, col];
                    }
                    else
                    {
                        tempLen = 1;
                    }
                }
            }

            tempLen = 1;
        }

        //========================
        //TODO Vertical check
        //TODO Diagonal check
        //========================

        Console.WriteLine("OUTPUT");
        for (int i = 0; i < bestLen; i++)
        {
            if (i == bestLen - 1)
            {             
                Console.WriteLine(bestElement);   
            }
            else
            {
                Console.Write(bestElement + ", "); 
            }
        }
    }
}
