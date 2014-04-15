/* You are given a sequence of positive integer values written into a string, separated by spaces.
   Write a function that reads these values from given string and calculates their sum. Example:
		string = "43 68 9 23 318" --> result = 461 
 */

using System;

class ReadValuesFromString
{
    static void Main()
    {
        Console.WriteLine("Please, enter some numbers separated by space to calculate their sum:");
        string inputString = Console.ReadLine();
        ////string inputString = "43 68 9 23 318";

        int sum = 0;
        string[] numsAsString = inputString.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < numsAsString.Length; i++)
        {
            sum += int.Parse(numsAsString[i]);
        }

        Console.WriteLine("The sum is: {0}", sum);
    }
}
