// тип 4, задается идентификатор, который возвращает занчение и принимает данные (аргументы)

string Method4(int count, string Symb)
{
    int i = 0;
    string result = ""; // можно записать как string result = string.Empty , т.е. пустое значение
    while (i < count)
    {
        result = result + Symb;
        i++;
    } 
    return result;
}
 string abc = Method4(5, "abc"); // если навести на метод то он покажет что внутри и как заполнять
Console.WriteLine(abc);
