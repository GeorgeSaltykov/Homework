// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void fillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
}

void printArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            System.Console.Write($" {someArray[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void arithmeticMean(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double arithmeticMean = new double();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arithmeticMean += array[i, j];
        }
        arithmeticMean /= array.GetLength(1);
        System.Console.WriteLine(arithmeticMean);
    }
}

int[,] array = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
fillArray(array);
printArray(array);
arithmeticMean(array);