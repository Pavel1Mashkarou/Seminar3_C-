// генерируем случайное количество уроков от 1 до 7, ученик получает оценку от 1 до 5, если 80% процентов 5 и нет 1-> уходит с последнего
// если 80% 2 и , то сидит +1 урок
// каждая перемена 15 мин, а урок 45 минут
// сколько ученик потратит времени в неделю


int Lesson() // Уроков в один день
{
    int Les = new Random().Next(1,8);
    return Les;
}

int Les1 = Lesson();  // Уроков в понедельник
int Les2 = Lesson();  // Уроков во вторник
int Les3 = Lesson();  // Уроков в среду
int Les4 = Lesson();  // Уроков в четверг
int Les5 = Lesson();  // Уроков в пятницу

System.Console.WriteLine($"Уроков в понедельник - {Les1}");
System.Console.WriteLine($"Уроков во вторник - {Les2}");
System.Console.WriteLine($"Уроков в среду - {Les3}");
System.Console.WriteLine($"Уроков в четверг - {Les4}");
System.Console.WriteLine($"Уроков в пятницу - {Les5}");



int Mark(int Les) // Отметка за урок
{
    int a = 1;
   
    double Bad = 0;
    double Good = 0;
    while (a<=Les)
    {
    int Mk = new Random().Next(1,6);
    if (Mk == 5) Good = (Good + Mk)/Les;
    if (Mk == 2 || Mk == 1) Bad = (Bad + Mk)/Les; 
    a++;
    }

    return ;
}


double Time(int Lesson, bool IsGood, bool IsBad)
{
    double time = Lesson * (45/60) + (Lesson-1)*(15/60);
    if (IsGood) time = time - Lesson * (45/60)- 15/60;
    if (IsBad) time = time + Lesson * (45/60)+ 15/60;
    return time;
}