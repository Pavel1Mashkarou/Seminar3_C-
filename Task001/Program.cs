int Read(string coordinate)
{
    System.Console.WriteLine($"Введите {coordinate}:");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int x = Read("x");
int y = Read("y");

int QouteNumb( int x, int y)
{
    if (x>0 && y>0) return 1;
    else if (x>0 && y<0) return 4;
    else if (x<0 && y>0) return 2;
    else return 3;
}

if (x==0 || y == 0) System.Console.WriteLine("Точка лежит на осях координат и не принадлежит четверти");
else System.Console.WriteLine($"Точка с координатами {x} {y} лежит в четверти - {QouteNumb(x,y)}");