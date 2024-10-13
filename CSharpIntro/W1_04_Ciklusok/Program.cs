// CTRL + K + C -> kijelöltek kommentelése
// CTRL + K + U -> kijelöltek unkommentelése


//for (int i = 0; i < 128; i++)
//{
//    Console.WriteLine($"{i} - {(char)i}");

//}

//int j = 1;
//do
//{
//    Console.WriteLine("{0} * {1} = {2}", j, 7, j*7);
//    j++;
//} while (j < 11);

//int k = 1;
//while (k< 11)
//{
//    Console.WriteLine("{0} * {1} = {2}", k, 8, k * 8);
//    k++;
//}

//F12 -> Go to definition
foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
{
    Console.ForegroundColor = color;
    //Console.Beep(400, 1000);
    Console.BackgroundColor = 15 - color;
    Console.WriteLine("Hello világ");
}
Console.BackgroundColor = ConsoleColor.Black;