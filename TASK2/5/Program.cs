/*Console.WriteLine("Enter RGB color 3 number: ");
byte R = byte.Parse(Console.ReadLine());
byte G = byte.Parse(Console.ReadLine());
byte B = byte.Parse(Console.ReadLine());
if (R == 0 && G == 0 && B == 0)
{
    Console.WriteLine("RGB: black " + R + " " + G + " " + B);
}
else if (R == 255 && G== 255 && B == 255)
{
    Console.WriteLine("RGB: white " + R + " "+ G + " " + B);
}
  else
{
    Console.WriteLine("RGB: " + R + " " + G + " " + B);
}
*/
using System;

struct RGB
{
    public byte Red;
    public byte Green;
    public byte Blue;
}

class Program
{
    static void Main()
    {
        RGB white = new RGB { Red = 255, Green = 255, Blue = 255 };
        RGB black = new RGB { Red = 0, Green = 0, Blue = 0 };
        Console.WriteLine("White color:");
        Console.WriteLine($"Red: {white.Red}, Green: {white.Green}, Blue: {white.Blue}");
        Console.WriteLine("Black color:");
        Console.WriteLine($"Red: {black.Red}, Green: {black.Green}, Blue: {black.Blue}");
    }
}