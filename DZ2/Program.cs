Console.Write(" vedi shislo1: ");
string? input = Console.ReadLine();

Console.Write(" vedi shislo2: ");
string? input2 = Console.ReadLine();

Console.Write(" vedi shislo3: ");
string? input3 = Console.ReadLine();

int number = Convert.ToInt32(input);
int number2 = Convert.ToInt32(input2);
int number3 = Convert.ToInt32(input3);

if (number > number2 && number > number3)
{
    Console.WriteLine("max= " + number);
}
else if (number2 > number3 && number2 > number)
{
    Console.WriteLine("max= " + number2);
}
else
{
    Console.WriteLine("max= " + number3);
}
