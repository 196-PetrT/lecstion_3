// тип 3, задается идентификатор, который возвращает занчение но не принимает данные (аргументы)

int Method3()
{
   
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
