Console. WriteLine("Ввести первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести второе число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine($"Максимальное число: {max}");