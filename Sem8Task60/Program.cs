// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0)
// 25(0,1,0)
// 34(1,0,0)
// 41(1,1,0)
// 27(0,0,1)
// 90(0,1,1)
// 26(1,0,1)
// 55(1,1,1)



void printArray(int[,,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            for (int k = 0; k < someArray.GetLength(2); k++)
            {
                System.Console.WriteLine($"{someArray[i, j, k]} ({i}, {j}, {k})");
            }
        }
    }
}

int[,,] array = new int[2, 2, 2] { { { 54, 34 }, { 25, 36 } }, { { 47, 86 }, { 99, 11 } } };
printArray(array);