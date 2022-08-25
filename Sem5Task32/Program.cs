// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
System.Console.WriteLine("Введите размер массива");

int[] fillArray(int userNumber)
{
    int[] array = new int[userNumber];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        System.Console.Write($"{array[i]} ");
    }
    return array;
}
int even(int[] someArray)
{
    int count = 0;
    for (int i = 0; i < someArray.Length; i++)
    {
        if(someArray[i] % 2 == 0) count++;
    }
    return count;
}
System.Console.WriteLine(even(fillArray(Convert.ToInt32(Console.ReadLine()))));