// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


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