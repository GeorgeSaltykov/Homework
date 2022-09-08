// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int naturalNumbersSum(int M, int N)
{
    int result = M;
    while (M < N)
    {
        result += M + 1;
        M++;
    }
    return result;
}
System.Console.WriteLine(naturalNumbersSum(1, 15));