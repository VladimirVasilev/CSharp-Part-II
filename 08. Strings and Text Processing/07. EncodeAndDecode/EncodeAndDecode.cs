using System;
using System.Text;
 
class EncryptDecrypt
{
    static void Main()
    {
        string inputText = "This is text for encoding and decoding!";
        string cypherKey = "cypher word";

        Console.WriteLine("After encoding, our text is:");

        char[] inputArr = inputText.ToCharArray();
        char[] cypherArr = new char[inputArr.Length];
        
        for (int i = 0, k = 0; i < cypherArr.Length; k++, i++)
        {
            if (k > cypherKey.Length - 1)
            {
                k = 0;
            }

            cypherArr[i] = cypherKey[k];
        }
                
        StringBuilder cipheredText = new StringBuilder();
        for (int i = 0; i < inputArr.Length; i++)
        {
            cipheredText.Append((char)(inputArr[i] ^ cypherArr[i])); // XOR Encoding
        }

        Console.WriteLine(cipheredText);
    } 
}
