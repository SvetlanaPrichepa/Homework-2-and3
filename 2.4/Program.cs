// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string WorkHoliday(int number)
{
    if (number > 0 && number < 8)
    {
        if (number == 7 || number == 6)
        {
            Console.Write("Этот день -> Выходной");
        }
        else
        {
            Console.Write("Этот день -> Рабочий");
        }
    }
    else
    {
        Console.Write("Нельзя определить выходной или рабочий день");
    }
    return " ";
}

