// 1. Написать метод, который генерирует массив 0 и 1 заданного количества N
//      3 -> 1 1 0
//           1 0 0
//           0 0 1

// void fillArray(int[] numberOf)
// {
//     for (int i = 0; i < numberOf.Length; i++)
//     {
//         numberOf[i] = new Random().Next(0, 2);
//         System.Console.Write($"{numberOf[i]} ");
//     }
// }
// System.Console.WriteLine("Введите размер массива");
// int userNumber = Convert.ToInt32(Console.ReadLine());
// int[] binaryArray = new int[userNumber];


// fillArray(binaryArray);
// System.Console.WriteLine();

// Написать метод, принимающий бинарное представление числа и возвращает десятичное представление числа

// double binaryToDecimal(int[] binary)
// {
//     double dec = new int();
//     int position = binary.Length - 1;
//     for (int i = 0; i < binary.Length; i++)
//     {
//         double degree = binary[i] * Math.Pow(2, position);
//         dec = dec + degree;
//         position--;
//     }
//     return dec;
// }

// Console.WriteLine(binaryToDecimal(binaryArray));

// Написать метод, принимающий десятиченое представление и основание СС в которую нужно это число перевести, 2<= основание СС<= 9
// 10,2 -> 1010
// 10,8 -> 12
// 6,6 -> 10

void convertTo(string number, int numeralSystem)
{
    string result = "";
    int toIntnumber = Convert.ToInt32(number);
    if (numeralSystem >= 2 && numeralSystem <= 9)
    {
        for (int i = 0; toIntnumber >= 1; i++)
        {
            if (toIntnumber % numeralSystem == 0) result += "0";
            else if (toIntnumber % numeralSystem > 0) result += Convert.ToString(toIntnumber % numeralSystem);
            toIntnumber /= numeralSystem;
        }
    }
    else System.Console.WriteLine("Вы ввели нечто некорректное");
    int[] res = new int[result.Length];
    for (int i = 0; i < result.Length; i++)
    {
        res[i] = result[result.Length - i - 1] - '0';
        Console.Write($"{res[i]}");
    }
}
System.Console.WriteLine("Введите число, которое хотите перевести в другую систему счисления, нажмите 'enter' затем введите число обозначающее систему счисления (от 2 до 9).");
convertTo(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));