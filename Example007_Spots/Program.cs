Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");

int x1 = 40;
int y1 = 1;
int x2 = 1;
int y2 = 30;
int x3 = 80;
int y3 = 30;

Console.SetCursorPosition(x1, y1);
Console.WriteLine("+");

Console.SetCursorPosition(x2, y2);
Console.WriteLine("+");

Console.SetCursorPosition(x3, y3);
Console.WriteLine("+");

int x =x1, y = x2;

int count = 0;

while(count < 800)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + x1) / 2;
        y = (y + y1) / 2;
    }
    if (what == 1)
    {
        x = (x + x2) / 2;
        y = (y + y2) / 2;
    }
    if (what == 2)
    {
        x = (x + x3) / 2;
        y = (y + y3) / 2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;

}