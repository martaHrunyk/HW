Console.WriteLine("Enter 2 integer value: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int sum = a + b;
int difference = a - b;
int product = a * b;
if (b != 0)
{
    int quotient = a / b;
    Console.WriteLine("Abbition: " + sum + Environment.NewLine
               + "Subtraction: " + difference + Environment.NewLine
               + "Multiplication: " + product + Environment.NewLine
               + "Division: " + quotient);
}
else
{
    Console.WriteLine("Division by zero is not allowed.");
}

