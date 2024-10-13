Console.ForegroundColor = ConsoleColor.Red;

switch (Console.ForegroundColor)
{
    case ConsoleColor.Green:
        Console.WriteLine("Zölddel írok"); break;

    case ConsoleColor.Red:
        Console.WriteLine("Pirossal írok"); break;

    default:
        Console.WriteLine("Nem ismert szín");
        break;
}
