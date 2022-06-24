Console.WriteLine("Ввести первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > max)
{
    int max = numberB;
    Console.WriteLine("$Максимально число: {max}.");
}
else
{
    Console.WriteLine("$Максимальное число:{max}");
}
