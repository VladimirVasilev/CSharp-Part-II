namespace _05.ChangeToUppercase
{
    using System;
    using System.Text.RegularExpressions;

    class ChangeToUppercase
    {
        static void Main()
        {
            //string input = Console.ReadLine();
            string input = @"<upper>We</upper> are <upper>living</upper> <lower>IN</lower> a <upper>yeow submarine</upper>.
                        <upper>We</upper> don't have <upper>anything</upper> else.";

            string changeUp = Regex.Replace(input, "<upper>(.*?)</upper>", m => m.Groups[1].Value.ToUpper());
            //Console.WriteLine(changeUp);

            string changeLow = Regex.Replace(changeUp, "<lower>(.*?)</lower>", m => m.Groups[1].Value.ToLower());
            Console.WriteLine(changeLow);

         

        }
    }
}
