int a = 15651;
int b = a % 10;
int c = (a % 100 - b) / 10;
int d = ((a % 1000) - (a % 100 - b)) / 100;
int e = ((a % 10000) - ((a % 1000) - (a % 100 - b))) / 1000;
int f = (a - ((a % 10000) - ((a % 1000) - (a % 100 - b)))) / 10000;
if (b == f & c == e)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
