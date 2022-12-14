// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void fillArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            someArray[i, j] = new Random().Next(-9, 10);
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

int[,] array = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];

void printElemet(int row, int column)
{
    if(row < array.GetLength(0) && column < array.GetLength(1) && row >= 0 && column >= 0)
    {
        System.Console.WriteLine(array[row - 1, column -1]);
    }
    else System.Console.WriteLine("Данного элемента в массиве нет");
}

fillArray(array);
printArray(array);
System.Console.WriteLine("Для вывода элемента массива введите номер строки, затем введите номер столбца");
printElemet(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));