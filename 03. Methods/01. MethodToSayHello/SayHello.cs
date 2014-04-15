/* Write a method that asks the user for his name and prints “Hello, <name>”
   (for example, “Hello, Peter!”). Write a program to test this method. */

using System;

class SayHello
{
    public static void SayHelloTo(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        Console.Write("Greetings, stranger! What is your name? ");
        string inputName = Console.ReadLine();

        SayHelloTo(inputName); //Call the method to say hello
    }
}
