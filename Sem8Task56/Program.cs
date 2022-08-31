// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void fillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
}

void printArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            System.Console.Write($"{someArray[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void lowerSum(int[,] someArray)
{
    int[,] sum = new int[someArray.GetLength(0), 1];
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            sum[i, 0] += someArray[i, j];
        }
    }
    int min = sum[0, 0];
    int count = 1;
    for (int i = 0; i < sum.GetLength(0); i++)
    {
        if (min > sum[i, 0]) 
        { 
            min = sum[i, 0];
            count = i + 1;
        }
    }
    System.Console.WriteLine($"В {count}-ой строке наименьшая сумма элементов");
}

int[,] array = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
fillArray(array);
printArray(array);
lowerSum(array);