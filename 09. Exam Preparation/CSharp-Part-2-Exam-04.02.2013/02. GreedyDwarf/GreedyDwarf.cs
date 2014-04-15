using System;

class GreedyDwarf
{
    static void Main()
    {
        //Input valley
        string[] valleyStr = Console.ReadLine().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

        int[] valleyNum = new int[valleyStr.Length];

        for (int i = 0; i < valleyNum.Length; i++)
        {
            valleyNum[i] = int.Parse(valleyStr[i]);
        }

        //Input patterns
        int patternCount = int.Parse(Console.ReadLine());

        int[][] patternNum = new int[patternCount][];

        for (int i = 0; i < patternNum.GetLength(0); i++)
        {
            string[] patternStr = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            patternNum[i] = new int[patternStr.Length];

            for (int j = 0; j < patternStr.Length; j++)
            {
                patternNum[i][j] = int.Parse(patternStr[j]);
            }
        }

        //TODO:
    }
}
