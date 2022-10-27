// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. Не использовать строки для расчета.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int NewNumber = 0;
int NumberWithoutSecDig()
{
    NewNumber = number / 100 * 10 + number % 10;
    return NewNumber;
}

NumberWithoutSecDig();
System.Console.WriteLine($"Удаляем вторую цифру числа {number}, получаем число -> {NewNumber}");

