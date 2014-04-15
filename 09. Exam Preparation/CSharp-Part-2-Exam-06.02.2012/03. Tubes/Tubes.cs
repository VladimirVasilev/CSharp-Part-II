using System;

class Tubes
{
    static void Main()
    {
        int tubesNum = int.Parse(Console.ReadLine());
        int tubesNeed = int.Parse(Console.ReadLine());
        int[] sizesArr = new int[tubesNum];

        for (int i = 0; i < tubesNum; i++)
        {
            sizesArr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(sizesArr);

        int leftBorder = 0;
        int rightBorder = sizesArr[sizesArr.Length - 1];
        int middle = (rightBorder + leftBorder) / 2;

        while (leftBorder <= rightBorder)
        {
            int counter = 0;

            foreach (var tube in sizesArr)
            {
                counter += tube / middle;
            }

            if (counter < tubesNeed)
            {
                rightBorder = middle - 1;
            }
            else
            {
                leftBorder = middle + 1;
            }

            middle = (rightBorder + leftBorder) / 2;
        }

        Console.WriteLine(middle);
    }
}
