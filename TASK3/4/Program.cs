int[] array = new int[5] { 1, 6, 3, 9, -8 };
int sum = 0;
int count = 0;
foreach (int x in array)
{
    if (x >= 0)
    {
        sum += x;
        count++;
    }
    else
    {
        break;
    }
}
if (count > 0)
{
    double average = (double)sum / count;
    Console.WriteLine($"Arithmetic average of the entered positive numbers: {average}");
}