Console.WriteLine("press number 1 ");
string input1 = Console.ReadLine()!;
Console.WriteLine("press number 2 ");
string input2 = Console.ReadLine()!;
Console.WriteLine("press number 3 ");
string input3 = Console.ReadLine()!;

int num1 = int.Parse(input1);
int num2 = int.Parse(input2);
int num3 = int.Parse(input3);
int max = num1;

if (num2 > max)
{
    max = num2;
}
 if (num3 > max)
 {
    max = num3;
 }

Console.WriteLine("Наибольшее число " + max);