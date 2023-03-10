double a = new Random().Next (-1000,1000);
Console.WriteLine (a);
double b = new Random().Next (-1000,1000);
Console.WriteLine (b);
double c= new Random ().Next(-1000,1000);
Console.WriteLine (c);

double max = a;

if (b>max) {max=b;}
if (c>max) {max=c;}

Console.Write("Максимальное число = ");
Console.WriteLine(max);
