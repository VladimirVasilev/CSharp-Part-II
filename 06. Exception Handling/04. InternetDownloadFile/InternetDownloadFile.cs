/* Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
   and stores it the current directory. Find in Google how to download files in C#. Be sure to catch 
   all exceptions and to free any used resources in the finally block. */

using System;
using System.Net;
using System.Threading;

class InternetDownloadFile
{
    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            Console.Write("Processing");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(150);
                Console.Write(".");
            }

            Console.WriteLine();

            try
            {
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../Downloaded_image.jpg");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Download complete! \nYou can find the file in your project folder :)))");
            }
            catch (WebException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" The URI formed by combining BaseAddress and address is invalid.\n -or-\n An error occurred while downloading the resource.");
            }
            catch (NotSupportedException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
        }
    }
}
