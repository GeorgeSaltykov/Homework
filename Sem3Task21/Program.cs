// Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] coordinates(string coordinates)
{
    string[] stringToArray = coordinates.Split(" ");
    int i = 0;
    double[] point = new double[3];
    while (i < 3)
    {
        point[i] = Convert.ToDouble(stringToArray[i]);
        i++;
    }
    return point;
}

System.Console.WriteLine("Введите координаты первой точки через пробел");
double[] firstPoint = coordinates(Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки через пробел");
double[] secondPoint = coordinates(Console.ReadLine());

void distance()
{
    double result = Math.Sqrt(Math.Pow((secondPoint[0] - firstPoint[0]), 2) + Math.Pow((secondPoint[1] - firstPoint[1]), 2) + Math.Pow((secondPoint[2] - firstPoint[2]), 2));
    Console.WriteLine($"Расстояние между точками равно: {result}");
}

distance();
