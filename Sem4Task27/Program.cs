// Напишите матод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int sum(string number)
// {
//     int result = 0;
//     for(int i = 0; i < number.Length; i++)
//     {
//         char[] stringToArray = new char[number.Length];
//         stringToArray[i] = number[i];
//         System.Console.WriteLine(stringToArray[i]);
//         int charToInt = Convert.ToInt32(stringToArray[i]);
//         System.Console.WriteLine(charToInt);
//         result = result + charToInt;
//     }
//     return result;
// }
// System.Console.WriteLine(sum(Console.ReadLine()));

int sum(string number)
{
    int i = 0;
    int[] result = new int[number.Length];
    int sum = 0;
    while (i < number.Length)
    {
        char[] stringToArray = new char[number.Length];
        stringToArray[i] = number[i];
        result[i] = Convert.ToInt32(stringToArray[i]);
        i++;
    }
    for(int index = 0; index < result.Length; index++)
    {
        sum = sum + result[i];
    }
    return sum;
}
System.Console.WriteLine(sum(Console.ReadLine()));

