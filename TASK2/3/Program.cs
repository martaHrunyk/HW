Console.WriteLine("Enter integer number  h, representing the time of day (hour).");
int time = int.Parse(Console.ReadLine());
switch (time)
{
    case 0:
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("It's late at night.Good night!");
        break;

    case 6:
    case 7:
    case 8:
    case 9:
    case 10:
    case 11:
    case 12:

        Console.WriteLine("It's morning.Good morning!");
        break;
   
    case 13:
    case 14:
    case 15:
    case 16:
    case 17:
    case 18:
    case 19:
        Console.WriteLine("It's afternoon.Good afternoon!");
        break;

    case 20:
    case 21:
    case 22:
    case 23:
        Console.WriteLine("It's evening.Good evening!");
        break;

    default:
        Console.WriteLine("Invalid hour entered.");
        break;
}