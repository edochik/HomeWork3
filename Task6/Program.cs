double threed(double xa, double xb, double ya, double yb, double za, double zb)
{
    double threedX = xa - xb;
    double threedY = ya - yb;
    double threedZ = za - zb;
    double threeXYZ = Math.Sqrt((threedX * threedX) + (threedY * threedY) + (threedZ * threedZ));
    return threeXYZ;
}

double xa = 7, xb = 1,
       ya = -5, yb = -1,
        za = 0, zb = 9;

Console.WriteLine("lenght " + Math.Round(threed(xa, xb, ya, yb, za, zb), 2));