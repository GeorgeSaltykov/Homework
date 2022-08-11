Console.WriteLine("Введите целое число.");
int someDigitNumber (int number)
{
    if(number > 0)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        if (number > 99)
        {
            number = number % 10;
        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    }
    else if(number < 0)
    {
        while (number < -999)
        {
            number = number / 10;
        }
        if (number < -99)
        {
            number = number % 10;
        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    }
    return number;
}
Console.WriteLine(someDigitNumber(Convert.ToInt32(Console.ReadLine())));