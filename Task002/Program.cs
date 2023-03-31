//Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int Read(string qoute)
{
    System.Console.WriteLine("Введите координатную четверть:");
    int x = int.Parse(Console.ReadLine());
    if (x>5 || x<1) throw new ArgumentOutOfRangeException("x");
    return x;
    
}

int qoute = Read("qoute");

void Magic(int qoute)
{
    if (qoute == 1)  System.Console.WriteLine("Значения x= (0;+бесконечность), y= (0;+бесконечность)");
    else if (qoute == 2)  System.Console.WriteLine("Значения x= (-бесконечность; 0), y= (0;+бесконечность)");
    else if (qoute == 3)  System.Console.WriteLine("Значения x= (-бесконечность; 0), y= (-бесконечность; 0)");
    else  System.Console.WriteLine("Значения x= (0;+бесконечность), y= (-бесконечность; 0)");
}

Magic( qoute);
