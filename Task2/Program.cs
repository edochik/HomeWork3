double length(double xa, double xb, double ya, double yb)
{
    double lengthX = xa - xb;
    double lengthY = ya - yb;
    double lengthXY = Math.Sqrt((lengthX * lengthX) + (lengthY * lengthY));
    return lengthXY;
}

double xa = 1;
double xb = 2;
double ya = 3;
double yb = 5;
Console.WriteLine("length " + Math.Round(length(xa, xb, ya, yb), 2));