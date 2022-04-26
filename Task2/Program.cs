//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
//между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09  
//A (7,-5); B (1,-1) -> 7,21

double findDistance(double xa, double xb, double ya, double yb)
{
    double distancX = xa - xb;
    double distancY = ya - yb;
    double distanceXY = Math.Sqrt((distancX * distancX) + (distancY * distancY));
    return distanceXY;
}

double xa = 7, xb = 1,
       ya = -5, yb = -1;

Console.WriteLine(Math.Round(findDistance(xa, xb, ya, yb),3));