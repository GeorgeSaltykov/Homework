// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void numberN(int numberN)
{
    if (numberN > 0)
    {
        for (int i = 1; i < numberN + 1; i++)
        {
            double result = Math.Pow(i, 3);
            Console.WriteLine(result);
        }

    }
    else if (numberN < 0)
    {
        for (int i = 1; i > numberN - 1; i--)
        {
            double result = Math.Pow(i, 3);
            Console.WriteLine(result);
        }
    }
    else Console.WriteLine("Вы ввели нечто не корректное");
}
Console.WriteLine("Введите число");
numberN(Convert.ToInt32(Console.ReadLine()));