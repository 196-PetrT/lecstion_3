﻿// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
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
string Replase(string Text, char OldValue, char NewValue) //char идентификатор символов
{
    string result = String.Empty;
    int length = Text.Length;
    for (int i = 0; i < length; i ++)
    {
        if (Text[i] == OldValue) // условие если символ по индексу совпадает с аргументом, то к пустой стр доб-тся новое значение
            result = result + $"{NewValue}";
        
        else 
            result = result + $"{Text[i]}"; // если не совпадает с аргументом то к пустой строке добавляет старое значение
    }
    return result;
}
string NewText = Replase(Text, ' ', '_');
NewText = Replase(NewText, 'К', 'к'); // чтобы повторить метод просто переназначаем значение аргумента NewText
NewText = Replase(NewText, 'с', 'С');
Console.WriteLine(NewText);
