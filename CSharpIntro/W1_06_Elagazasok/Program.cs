int x = 10;

if (x < 10)
{
    Console.WriteLine("kevés");
}
else
{
    Console.WriteLine("sok");
}

//Ha x kissebb mint 10 akkor y = 0 amúgy 1
int y = x < 10 ? 0 : 1;
Console.WriteLine(y);
