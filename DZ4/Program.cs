// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write(" vedi shislo: ");
string? input = Console.ReadLine();
int number = Convert.ToInt32(input);
//Console.WriteLine(input);
int number2 =1;
int number3;

while (number>number2)
{
    number3 =number2%2;
if (number3>0)
{
    number2++;
}
else
{
    Console.WriteLine(number2+" ");
    number2++;
}
}