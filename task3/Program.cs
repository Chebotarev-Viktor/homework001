Console.WriteLine("press number");
string input = Console.ReadLine()!;

int num = int.Parse(input);


if (num % 2 != 1)
{
    Console.WriteLine("четное" + num);
}
else
{
    Console.WriteLine("нечетное" + num);
}