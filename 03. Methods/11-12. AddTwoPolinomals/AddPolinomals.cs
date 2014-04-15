/* Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		x2 + 5 = 1x2 + 0x + 5 
   Extend the program to support also subtraction and multiplication of polynomials.
 */

using System;

class AddPolinomals
{
    static decimal[] SubtractPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial, out decimal[] subtractPolynomials)
    {
        subtractPolynomials = BiggerLength(firstPolynomial, secondPolynomial);
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            subtractPolynomials[i] = firstPolynomial[i];
        }

        for (int i = 0; i < secondPolynomial.Length; i++)
        {
            subtractPolynomials[i] -= secondPolynomial[i];
        }

        return subtractPolynomials;
    }

    static void PrintPolynomials(decimal[] sumPolynomials)
    {
        foreach (decimal element in sumPolynomials)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }

    static decimal[] SumPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial, out decimal[] sumPolynomials)
    {
        sumPolynomials = BiggerLength(firstPolynomial, secondPolynomial);

        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            sumPolynomials[i] = firstPolynomial[i];
        }

        for (int i = 0; i < secondPolynomial.Length; i++)
        {
            sumPolynomials[i] += secondPolynomial[i];
        }

        return sumPolynomials;
    }

    static decimal[] BiggerLength(decimal[] firstPolynomial, decimal[] secondPolynomial)
    {
        int biggerLen = firstPolynomial.Length;
        if (firstPolynomial.Length < secondPolynomial.Length)
        {
            biggerLen = secondPolynomial.Length;
        }

        decimal[] sumPolynomials = new decimal[biggerLen];
        return sumPolynomials;
    }

    static decimal[] MultiplPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial, out decimal[] multiplPolynomials)
    {
        multiplPolynomials = BiggerLength(firstPolynomial, secondPolynomial);

        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            multiplPolynomials[i] = firstPolynomial[i];
        }

        for (int i = 0; i < secondPolynomial.Length; i++)
        {
            multiplPolynomials[i] *= secondPolynomial[i];
        }

        return multiplPolynomials;
    }

    static void Main()
    {
        decimal[] firstPolynomial = new decimal[] { 5, 2, 1 };
        decimal[] secondPolynomial = new decimal[] { 2, 3, 2, 48 };

        decimal[] sumPolynomials;
        SumPolynomials(firstPolynomial, secondPolynomial, out sumPolynomials);

        Console.Write("After the Addition: ");
        PrintPolynomials(sumPolynomials);

        decimal[] subtractPolynomials;
        SubtractPolynomials(firstPolynomial, secondPolynomial, out subtractPolynomials);

        Console.Write("After the Subtraction: ");
        PrintPolynomials(subtractPolynomials);

        decimal[] multiplPolynomials;
        MultiplPolynomials(firstPolynomial, secondPolynomial, out multiplPolynomials);

        Console.Write("After the Multiplication: ");
        PrintPolynomials(multiplPolynomials);
    }
}
