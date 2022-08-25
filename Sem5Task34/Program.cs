// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

System.Console.WriteLine("Введите размер массива");

int[] fillArray(int userNumber)
{
    int[] array = new int[userNumber];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
    return array;
}
int unevenSum(int[] array)
{
    int sum = new int();
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) sum += array[i];
    }
    return sum;
}
System.Console.WriteLine(unevenSum(fillArray(Convert.ToInt32(Console.ReadLine()))));