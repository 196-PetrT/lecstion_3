// сортировка в массиве значений по возрастаниию

int [] array =  { 1, 4, 6, 7, 8, 9, 5, 7, 4};

// для удобства сделаем доп метод для вывода массива на экран

void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); // для печати в строчку и добавляя пробел
    }
    Console.WriteLine(); // разделение между строками
}
// добавляем метод который упорядочивает наш массив

void SortMassiv(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++) // -1 потому что в j мы добавили +1 к размерности массива
    {
        int MinPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[MinPosition]) MinPosition = j;
        }

        int temporary = array[i]; // temporary вносит в память значение индекса
        array[i] = array[MinPosition]; // вместо значения индекса записывает мин значение
        array[MinPosition] = temporary; // на мин значение записывает значение из памяти
    }
}
PrintArray(array); 
SortMassiv(array);
PrintArray(array);