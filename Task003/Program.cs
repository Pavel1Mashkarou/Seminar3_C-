double Read(string coordinate)
{
    System.Console.WriteLine($"Введите {coordinate}:");
    double x = double.Parse(Console.ReadLine());
    return x;
}

double x1 = Read("x");
double y1 = Read("y");

double x2 = Read("x");
double y2 = Read("y");

double Magic(double x1, double y1, double x2, double y2)
{
    double X = x2 - x1;
    if (X < 0) X = -X;
    double Y = y2 - y1;
    if (Y < 0) Y = -Y;
    double C1 = (double)Math.Pow(X, 2) + (double)Math.Pow(Y, 2);
    double C = (double)Math.Round(Math.Sqrt(C1),2);
    return C;
}

double C = Magic(x1, y1, x2, y2);
System.Console.WriteLine($"Результат равен {C}");
