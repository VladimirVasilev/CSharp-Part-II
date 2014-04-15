/* Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
   reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
   Be sure to catch all possible exceptions and print user-friendly error messages. */

using System;
using System.IO;
using System.Security;

class ReadPrintFileContent
{
    static void PrintFileContent(string pathFile)
    {
        string contentFile = System.IO.File.ReadAllText(pathFile);
        Console.WriteLine(contentFile);
    }

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Please, enter the full path to the file:");
        try
        {
            string pathFile = Console.ReadLine();
            PrintFileContent(pathFile);
        }
        catch (FileNotFoundException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The file specified in path was not found.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
        }
        catch (ArgumentNullException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The given path is NULL\n and some method received a null argument!");
        }
        catch (ArgumentException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters.");
        }
        catch (PathTooLongException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" The specified path, file name, or both exceed\n the system-defined maximum length." +
                "Path must be\n less than 248 characters, and file names\n must be less than 260 characters.");
        }
        catch (NotSupportedException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The given path is in an invalid format.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UnauthorizedAccesException detected! The reasons may be the following:\n" +
                " - Path specified a file that is read-only.\n - This operation is not supported on the current platform.\n" +
                " - The caller does not have the required permission.");
        }
        catch (SecurityException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorry, but you does not have the required permission.");
        }
        catch (IOException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("An I/O (Input/Output) error occurred while opening the file.");
        }
    }
}
