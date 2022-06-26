Console.WriteLine("Ввести лимит: ");
int lim = Convert.ToInt32(Console.ReadLine());
int number = 1;

while (number < lim)
{
    if((number % 2) == 0) Console.Write(number + " ");
    number++;
}

Console.Write($"|{lim}");
