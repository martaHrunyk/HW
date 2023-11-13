using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Reflection;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = SumOfDigits(number);
        Console.WriteLine($"Sum of digits: {sum}");
    }
    static int SumOfDigits(int num)
    {
        int sum = 0;
        num = Math.Abs(num);
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}





