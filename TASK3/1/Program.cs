
using System;

Console.WriteLine("Enter two integer numbers a and b");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int count = CountDividedOnThree(a, b);
Console.WriteLine($"integers in the range [{a}..{b}], are divided by 3 without remainder: {count}");
static int CountDividedOnThree(int start, int end)
{
    int count = 0;

    for (int i = start; i <= end; i++)
    {
        if (i % 3 == 0)
        {
            count++;
        }
    }

    return count;
}