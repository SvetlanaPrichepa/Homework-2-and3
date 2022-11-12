// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе. Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Promt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Sum (int number)
{
    int sum = 0;
    for(int i = 0; i < number; i++)
    {
        sum = sum + number % 10;
        number /= 10;
    }
    return sum;
}


int number = Promt("Введите число >> ");
int sum = Sum(number);
Console.WriteLine($"Сумма чисел равна {sum} ");

