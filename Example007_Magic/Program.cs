﻿Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");
int xa = 1,     ya = 1,
    xb = 1,     yb = 60,
    xc = 60,     yc = 60;

Console.SetCursorPosition(xa, ya);
Console.Write("+");
Console.SetCursorPosition(xb, yb);
Console.Write("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 1;
while (count < 10000)
{
    int what = new Random().Next(0, 3); // [0, 1, 2]
    if (what == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
    {
        
    }
}
