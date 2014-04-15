namespace _12.ParseAnURL_address
{
    using System;
   
    class ParseAdressURL
    {
        static void Main()
        {
            //// MODEL --> [protocol]://[server]/[resource]

            string inputURL = @"http://www.last.fm/music/Metallica/Enter+Sandman.php";

            int index2Dots = 0;
            int index2Slash = 0;
            int index1Slash = 0;

            for (int i = 0; i < inputURL.Length - 2; i++)
            {
                if (inputURL.Substring(i, 1) == ":")
                {
                    index2Dots = i;
                }
                else if (inputURL.Substring(i, 2) == "//")
                {
                    index2Slash = i;
                    for (int k = i + 2; k < inputURL.Length; k++)
                    {
                        if (inputURL.Substring(k, 1) == "/")
                        {
                            index1Slash = k;
                            break;
                        }
                    }
                }
            }

            int protokolLen = index2Dots;
            int serverLen = index1Slash - index2Slash;
            int resourceLen = inputURL.Length - 1 - index1Slash;

            string protokolStr = inputURL.Substring(0, protokolLen);
            Console.WriteLine(@"[protokol] = ""{0}""", protokolStr);

            string serverStr = inputURL.Substring(index2Slash + 2, serverLen - 2);
            Console.WriteLine(@"[server] = ""{0}""", serverStr);

            string resourceStr = inputURL.Substring(index1Slash, resourceLen + 1);
            Console.WriteLine(@"[resource] = ""{0}""", resourceStr);
        }
    }
}
