// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// нельзя использовать pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void degree(int number, int degree)
{
    int result = number;
    for (int i = 2; i <= degree; i++)
    {
        result = result * number;
    }
    if(degree == 0)
    {
        result = 1;
    }
    Console.WriteLine(result);
}
degree(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
