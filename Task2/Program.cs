Console.WriteLine("Hello, pls enter 3 numbers");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int maxnum = 0;
if (num2 < num3)
{
    maxnum = num3;
}
else if (num1 < num2)
{
    maxnum = num2;
}
else
{
    maxnum = num1;
}
Console.WriteLine(maxnum);