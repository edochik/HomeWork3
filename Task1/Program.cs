int axisXY(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine(1);
    if (x > 0 && y < 0) Console.WriteLine(2);
    if (x < 0 && y < 0) Console.WriteLine(3);
    if (x < 0 && y > 0) Console.WriteLine(4);
    return x ^ y;
}

int x = -1;
int y = 1;
axisXY(x, y);