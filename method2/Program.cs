// метод что-то принимает, но не возвращает

/*void Method1(string msg)
{
    Console.WriteLine(msg);
}
Method1(msg: "Автор Петр Т");
*/
void Method21(string msg, int count, int i = 0)
{
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++; // инкремент (добавляет 1), если -- то декремент
    }
}
Method21("Автор Петр Т", 4); // указываем что хотим увидеть " ", и сколько раз 4
