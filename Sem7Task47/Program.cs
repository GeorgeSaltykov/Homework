// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] fillArray(int first, int second)
{
    double[,] array = new double[first, second];
    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j % 2 == 0) array[i, j] = Math.Round(random.NextDouble() * 10, 1);
            else array[i, j] = Math.Round(random.NextDouble() * (-10), 1);
        }
    }
    return array;
}
void printArray(double[,] someArray)
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

printArray(fillArray(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));