// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
// заменить большими «К», а большие «С» заменить на маленькие «с».

string Text = "Что значит «Дан текст»? Как вы уже помните, из предыдущих лекций, дан – это"
            + "непонятно. Ввёл пользователь? Считали из файла? Взяли с базы данных? Из какого-то"
            + "сервиса может быть, скачали и так далее. Поэтому чётко определяем для себя, что"
            + "значит, дан. В нашем случае мы будем считать, что он просто будет храниться как"
            + "отдельная строка.";

/* string T = "qwertyu";
               0123456
    T[0] = q
*/
string Replase(string Text, char OldValue, char NewValue)
{
    string result = String.Empty;
    int length = Text.Length;
    for (int i = 0; i < length; i ++)
    {
        if (Text[i] == OldValue) 
            result = result + $"{NewValue}";
        
        else 
            result = result + $"{Text[i]}";
    }
    return result;
}
string NewText = Replase(Text, ' ', '_');
NewText = Replase(NewText, 'К', 'к');
NewText = Replase(NewText, 'с', 'С');
Console.WriteLine(NewText);
