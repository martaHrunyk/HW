//Enter the name of the drink (coffee, tea, juice, water). Print the name and price of the drink.
Console.WriteLine("Enter the name of the drink (coffee, tea, juice, water).");
string text = Console.ReadLine();
switch (text.ToLower())
{
    case "coffee":
        Console.WriteLine($"price of {text} = " + 20);
        break;
    case "tea":
        Console.WriteLine($"price of {text} = " + 15);
        break;
    case "juice":
        Console.WriteLine($"price of {text} = " + 12);
        break;
    case "water":
        Console.WriteLine($"price of {text} = " + 5);
        break;
}


