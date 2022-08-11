Console.WriteLine("Введите трехзначное число.");
int Number = Convert.ToInt32(Console.ReadLine());
int threeDigitNumber (int number)
{
    int secondNumber = number % 100 / 10;
    return secondNumber;
}
Console.WriteLine($"Вторая цифра вашего числа: {threeDigitNumber(Number)}");