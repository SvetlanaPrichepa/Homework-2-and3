//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintArray(double[,] matr)
{
for(int i = 0; i < matr.GetLength(0); i++)
 {
    for(int j = 0; j < matr.GetLength(1); j++)           //выведение
    {
        Console.Write($"{matr[i, j]} ");
    }
   Console.WriteLine(); 
 }
}

void FillArray(double[,] matr)
{
for(int i = 0; i < matr.GetLength(0); i++)
 {
    for(int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = Convert.ToDouble(new Random().Next(-9,10)) / 10;       //заполнение
    } 
 }
}

Console.WriteLine("введите количество строк");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matr = new double[line, column];
FillArray(matr);
PrintArray(matr);
