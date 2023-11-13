Console.WriteLine("Enter 2 integer numbers. ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a > 0 && b > 0)
{
    Console.WriteLine("Both numbers are greater than 0.");
}
else if (a > 0 && b < 0)
{
    Console.WriteLine("First number is greater than 0, but second number is not.");
}
else if (a < 0 && b > 0)
{
    Console.WriteLine("Second number is greater than 0, but first number is not.");
}
else if (a < 0 && b < 0)
{
    Console.WriteLine("None of the numbers are greater than 0.");
}