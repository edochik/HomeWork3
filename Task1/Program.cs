﻿//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
//выдаёт номер четверти плоскости, в которой находится эта точка.


int axisXY(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine(1);
    if (x > 0 && y < 0) Console.WriteLine(2);
    if (x < 0 && y < 0) Console.WriteLine(3);
    if (x < 0 && y > 0) Console.WriteLine(4);
    return x ^ y;
}

int x = -3;
int y = 34;
axisXY(x, y);