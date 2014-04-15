/* Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
    Example: N = 3, K = 2 --> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3} */

using System;

class VariationOfKElements
{
    static void Main(string[] args)
    {
        //Input
        Console.Write("Please, set a value of \"n\" to define a interval [0..n]:\n n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, set a value of \"k\" elements:\n k = ");
        int k = int.Parse(Console.ReadLine());

        int[] myArray = new int[k];
        
        //Output
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("All the variations of {0} elements from the set [0..{1}] are:", k, n);
        Variation(myArray, n, 0); //Call the method
    }

    //Method that calculates all the variations of K elements from the set [1..N].
    static void Variation(int[] myArray, int n, int index)
    {
        if (index == myArray.Length)
        {
            Console.Write("{");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i != myArray.Length - 1)
                {                 
                    Console.Write(myArray[i] + ", ");   
                }
                else
                {
                    Console.Write(myArray[i]);
                }
            }

            Console.WriteLine("}");

        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                myArray[index] = i;
                Variation(myArray, n, index + 1);
            }
        }
    }
}
