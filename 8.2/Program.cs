// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

void FillArray(int[,] matr)                         //Функция заполнения массива случайными числами
{
for(int i = 0; i < matr.GetLength(0); i++)
 {
    for(int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(1,10);
    }
 }
 return;
}


void PrintArray(int[,] matr)
{
for(int i = 0; i < matr.GetLength(0); i++)
 {
    for(int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
   Console.WriteLine(); 
 }
}

void SumElements(int[,] array)
{
    int row = 0;
    int sumRow = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        row += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
        if (sum < row)
        {
            row = sum;
            sumRow = i;
        }
        sum = 0;
    }
    Console.Write($"Минимальная сумма элементов в(во) {sumRow + 1} строке");
}

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SumElements(array);



