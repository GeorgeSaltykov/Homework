// Напишите матод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void sum(string number)
{
    int result = 0;
    for(int i = 0; i < number.Length; i++)
    {
        char stringTo = number[i];
        result += stringTo - '0';
    }
    System.Console.WriteLine(result);
}
sum(Console.ReadLine());