Console.WriteLine("Ввендите номер дня недели (от одного до семи).");
string WeekDay (int number) {
    string [] week = {"будний день", "будний день", "будний день", "будний день", "будний день", "выходной день", "выходной день", ""};
    if (number > 0 && number < 8) 
    {
        number--;
        return week [number];
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число");
        return week [7];
    }

}
Console.WriteLine(WeekDay(Convert.ToInt32(Console.ReadLine())));
