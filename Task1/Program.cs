Console.WriteLine("Введите превое число: ");
int numberMax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberMin = Convert.ToInt32(Console.ReadLine());
if (numberMax > numberMin)
{
    Console.WriteLine($"Минимальное число:{numberMin}.");
    Console.WriteLine($"Максимальное число:{numberMax}.");
}
else
{
    Console.WriteLine($"Минимальное число:{numberMax}.");
    Console.WriteLine($"Максимальное число:{numberMin}.");
}