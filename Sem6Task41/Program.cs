// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void positiveNumbers(string userNumbers)
{
    string[] ToIntConvert = userNumbers.Split(", ");
    int[] positiveInt = new int[ToIntConvert.Length];
    int count = 0;
    for (int i = 0; i < positiveInt.Length; i++)
    {
        positiveInt[i] = Convert.ToInt32(ToIntConvert[i]);
        System.Console.Write($"{positiveInt[i]} ");
        if(positiveInt[i] > 0) count++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine(count);
}

positiveNumbers(Console.ReadLine());