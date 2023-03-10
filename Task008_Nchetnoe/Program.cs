int a = new Random().Next (-1000,1000);
Console.WriteLine (a);

for (int i=2; i<a; i=i+2)
{
    Console.Write($"{i} ");
}