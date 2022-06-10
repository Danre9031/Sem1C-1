
Console.Write(" vedi shislo1: ");
string? input = Console.ReadLine();

Console.Write(" vedi shislo2: ");
string? input2 = Console.ReadLine();

int number = Convert.ToInt32(input);
int number2 = Convert.ToInt32(input2);

if (number2 > number)
{
    Console.WriteLine("max= " + number2);
}
else
{
    Console.WriteLine("max= " + number);
}