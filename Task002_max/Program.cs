Console.Write ("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine ());
int max = a;
int min = a;

if (b>max)
{
    max=b;
    Console.Write ("Максимальное число: ");
    Console.WriteLine (max);
    Console.Write ("Минимальное число: ");
    Console.WriteLine (min);
}
else
{
    min=b;
    Console.Write ("Максимальное число: ");
    Console.WriteLine (max);
    Console.Write ("Минимальное число: ");
    Console.WriteLine (min);
}