Console.WriteLine("Программа для сравнения чисел. Введите число, затем введите второе.");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumbeer = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
int min = secondNumbeer;
if(firstNumber < secondNumbeer)
{
    max = secondNumbeer;
    min = firstNumber;
}
Console.WriteLine($"Число {max} больше числа {min}");