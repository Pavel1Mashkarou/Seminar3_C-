int Read()
{
    System.Console.WriteLine("Введите число:");
    int x = int.Parse(Console.ReadLine());
    if (x < 0) throw new ArgumentOutOfRangeException("x");
    return x;
}

int x = Read();

void Magic(int x)
{
    int a = 1;
    int b = 0;
    while (a <= x)
    {
        b = (int)Math.Pow(a, 2);
        a++;
        System.Console.Write(b + " ");
    }
    
}

Magic(x);

// генерируем случайное количество уроков от 1 до 7, ученик получает оценку от 1 до 5, если 80% процентов 5 и нет 1-> уходит с последнего
// если 80% 2 и , то сидит +1 урок
// каждая перемена 15 мин, а урок 45 минут
// сколько ученик потратит времени в неделю