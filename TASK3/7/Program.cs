
using System;

public class Program
{
    public static bool ContainsEvenDigit(int n)
    {
        while (n > 0)
        {
            int digit = n % 10;

            if (digit % 2 == 0)
            {
                return true;
            }
            n = n / 10;
        }
        return false; 
    }
    public static bool ContainsOnlyOddDigits(int n)
    {
        while (n > 0)
        {
            int digit = n % 10;

            if (digit % 2 == 0)
            {
                return false;
            }
            n = n / 10;
        }
        return true; 
    }
    public static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        if (ContainsOnlyOddDigits(number))
        {
           Console.WriteLine("The number contains only odd digits.");
        }
        else if (ContainsEvenDigit(number))
        {
           Console.WriteLine("The number contains only even digits.");
                    
        }
        else
        {
            Console.WriteLine("The number contains both even and odd digits.");
        }
    }
}