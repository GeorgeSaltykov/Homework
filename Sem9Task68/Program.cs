// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int AckermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0
        && n == 0)
        return AckermanFunction(m - 1, 1);
    if (m > 0
        && n > 0)
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    return AckermanFunction(m, n);
}

System.Console.WriteLine(AckermanFunction(2, 3));