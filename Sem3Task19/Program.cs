// Напишите метод, который принимает на вход шестизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// строки использовать нельзя

void palindrome(int userNumber)
{
    int first = userNumber / 100000;
    int last = userNumber % 10;
    if (userNumber > 99999 && userNumber < 1000000)
    {
        if (first == last)
        {
            first = userNumber / 10000 % 10;
            last = userNumber / 10 % 10;
        }
        if (first == last)
        {
            first = userNumber / 1000 % 10;
            last = userNumber / 100 % 10;
        }
        if (first == last)
        {
            Console.WriteLine("Ваше число является палиндромом");
        }
        else
        {
            Console.WriteLine("Не является полиндромом");
        }
    }
    else if (userNumber < -99999 && userNumber > -1000000)
    {
        if (first == last)
        {
            first = userNumber / 10000 % 10;
            last = userNumber / 10 % 10;
        }
        if (first == last)
        {
            first = userNumber / 1000 % 10;
            last = userNumber / 100 % 10;
        }
        if (first == last)
        {
            Console.WriteLine("Ваше число является палиндромом");
        }
        else
        {
            Console.WriteLine("Не является полиндромом");
        }
    }

    else Console.WriteLine("Ваше число не соответствует требованиям");


}

Console.WriteLine("Введите шестизначное число");
palindrome(Convert.ToInt32(Console.ReadLine()));