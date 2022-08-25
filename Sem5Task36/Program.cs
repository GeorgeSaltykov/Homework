// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

float[] fillArray(int userNumber)
{
    float[] array = new float[userNumber];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1001);
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
    return array;
}

float diff(float[] array)
{
    float min = array[0];
    float max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i]) min = array[i];
        else if(max < array[i]) max = array[i];
    }
    return max - min;
}
System.Console.WriteLine("Введите размер массива");
System.Console.WriteLine(diff(fillArray(Convert.ToInt32(Console.ReadLine()))));