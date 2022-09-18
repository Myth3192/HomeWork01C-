Console.WriteLine("Hello, please enter two numbers");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Number " + num1 + " is more then " + num2);
}
else if (num1 < num2)
{
    Console.WriteLine("Number " + num2 + " is more then " + num1);
}
else{
    Console.WriteLine("Numbers are equal");
}
    