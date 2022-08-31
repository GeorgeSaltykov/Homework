// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] multiplyMatrix(int[,] first, int[,] second)
{
    int[,] multiplyMatrix = new int[first.GetLength(0), first.GetLength(0)];
    for (int row = 0; row < multiplyMatrix.GetLength(0); row++)
    {
        for (int column = 0; column < multiplyMatrix.GetLength(1); column++)
        {
            int i = 0;
            while(i < first.GetLength(1))
            {
            multiplyMatrix[row, column] += first[row, i] * second[i, column];
            i++;
            }
        }
    }
    return multiplyMatrix;
}

int[,] firstMatrix = new int[3, 3];
int[,] secondMatrix = new int[3, 3];
fillArray(firstMatrix);
printArray(firstMatrix);
System.Console.WriteLine();
fillArray(secondMatrix);
printArray(secondMatrix);
System.Console.WriteLine();
printArray(multiplyMatrix(firstMatrix, secondMatrix));