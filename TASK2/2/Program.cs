Console.WriteLine("Enter a real number: ");
double a = Convert.ToDouble(Console.ReadLine());
int f1 = (int)(a * 10) % 10;
int f2 = (int)(a * 100) % 10; 
Console.WriteLine("Sum of {0} and {1} is {2}", f1, f2, f1 + f2);