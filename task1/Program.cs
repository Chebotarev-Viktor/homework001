Console.WriteLine("press number 1 ");
string input1 = Console.ReadLine()!;
Console.WriteLine("press number 2 ");
string input2 = Console.ReadLine()!;

int A = int.Parse(input1);
int B = int.Parse(input2);

if (A>B)
{
    Console.WriteLine("наибольшее"+ A , "наименьшее"+ B);
}
else
{
     Console.WriteLine("наибольшее"+ B , "наименьшее"+ A);
}



