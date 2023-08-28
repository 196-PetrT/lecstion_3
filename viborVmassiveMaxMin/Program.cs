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
// добавляем метод который упорядочиванет наш массив



PrintArray(array); 

