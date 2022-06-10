// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write(" vedi shislo: ");
string? input = Console.ReadLine();
int number = Convert.ToInt32(input);

int result=number%2;
if (result>0)
{
    Console.WriteLine("Нечетное");
}
else
{
    Console.WriteLine("четное");
}