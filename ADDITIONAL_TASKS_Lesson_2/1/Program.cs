using _1;
using static _1.Cat;

Console.WriteLine("Enter food for cat (Fish, Mouse, Chicken, Milk): ");
string foodCat = Console.ReadLine();

if (Enum.TryParse<Cat.Food>(foodCat, true, out Cat.Food foodType))
{
    Cat myCat = new Cat();
    myCat.EatSomething(foodType);
}
else
{
    Console.WriteLine("Invalid food type.");
}