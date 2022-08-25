// Напишите метод, который задаёт массив из 8 элементов (диапазон от 1 до 100) и выводит их на экран.
// пример вывода
// [1,4,5,3,1,2,3,9]
// [4,45,53,31,14,25,63,19]

void fillArray()
{
    int[] array = new int[8];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,101);
        Console.Write($"{array[i]} ");
    }
}
fillArray();