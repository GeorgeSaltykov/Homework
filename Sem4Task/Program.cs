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

// Написать метод, принимающий десятичное представление числа  и основание системы счисления, в которую это число нужно перевести

void convertTo(string number, int numeralSystem)
{
    string result = "";
    int toIntnumber = Convert.ToInt32(number);
    if (numeralSystem == 2)
    {
        for (int i = 0; toIntnumber >= 1; i++)
        {
            if (toIntnumber % numeralSystem == 0)
            {
                result = result + "0";
            }
            else
            {
                result = result + "1";
            }
            toIntnumber = toIntnumber / numeralSystem;
        }
    }
    if (numeralSystem == 3)
    {
        if (toIntnumber % numeralSystem == 0)
        {
            result = result + "0";
        }
        else if (toIntnumber % numeralSystem ==)
        {
            result = result + "1";
        }
        toIntnumber = toIntnumber / numeralSystem;
    }
    int[] res = new int[result.Length];
    for (int i = 0; i < result.Length; i++)
    {
        res[i] = result[result.Length - i - 1] - '0';
        Console.Write($"{res[i]}");
    }
}
convertTo(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));