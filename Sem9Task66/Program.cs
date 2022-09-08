// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int result = new int();
int naturalNumbersSum(int m, int n)
{
    if (m <= n)
    {
        result += m;
        naturalNumbersSum(m + 1, n);
    }
    return result;
}
System.Console.WriteLine(naturalNumbersSum(1, 15));