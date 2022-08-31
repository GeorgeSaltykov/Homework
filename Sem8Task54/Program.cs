// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            System.Console.Write($" {someArray[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void descendingOrder(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            for (int a = 0; a < someArray.GetLength(1) - 1; a++)
            {
                if(someArray[i, a + 1] > someArray[i, a])
                {
                    int change = someArray[i, a];
                    someArray[i, a] = someArray[i, a + 1];
                    someArray[i, a + 1] = change;
                }
            }
        }
    }
}

int[,] array = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
fillArray(array);
printArray(array);
System.Console.WriteLine();
descendingOrder(array);
printArray(array);