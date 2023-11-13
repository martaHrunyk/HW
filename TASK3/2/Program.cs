Console.WriteLine("Enter some string text: ");
string text = Console.ReadLine();
for (int i = 1; i < text.Length; i += 2)
{
    Console.WriteLine(text[i]);
}


