// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = -b1 + b2
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

double[,] fillArray(string userValues)
{
    string[] toIntConvert = userValues.Split(", ");
    double[,] points = new double[3, 2];                                  // {b1, k1} {b2, k2} {x, y}
    int count = 0;
    for (int i = 0; i < points.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < points.GetLength(1); j++)
        {
            points[i, j] = Convert.ToDouble(toIntConvert[count]);
            count++;
            // System.Console.Write($"{points[i, j]} ");
        }
        // System.Console.WriteLine();
    }
    return points;
}

void intersectionPoint(double[,] points)
{
    if (points[0, 1] != points[1, 1])
    {
        points[2, 0] = (points[1, 0] - points[0, 0]) / (points[0, 1] - points[1, 1]);
        points[2, 1] = points[0, 1] * points[2, 0] + points[0, 0];
        System.Console.WriteLine($"({points[2, 0]}; {points[2, 1]})");
    }
    else System.Console.WriteLine("Прямые параллельны");
}

intersectionPoint(fillArray(Console.ReadLine()));