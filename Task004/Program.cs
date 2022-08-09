Console.WriteLine("Программа выявления максимального числа из трех. Введите три числа.");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
if(max < secondNumber)
{
    max = thirdNumber;
}
else if(max < thirdNumber)
{
    max = thirdNumber;
}
Console.WriteLine($"Максимальное число: {max}");