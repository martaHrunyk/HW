Console.WriteLine("Enter two integers numbers represent the day and month");
int day = int.Parse(Console.ReadLine());
int month = int.Parse(Console.ReadLine());
if (IsValidDate(day, month))
{
    Console.WriteLine($"The numbers {day} and {month} can represent a valid day and month.");
}
else
{
    Console.WriteLine($"The numbers {day} and {month} cannot represent a valid day and month.");
}
    static bool IsValidDate(int day, int month)
{
    return (day >= 1 && day <= 31) && (month >= 1 && month <= 12);
}