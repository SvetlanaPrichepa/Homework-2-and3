// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int Promt(string msg)
{
    Console.Write(msg);
    int temp = Convert.ToInt32(Console.ReadLine());
    return temp;
}



void FillArray(int[,] matr)                         //Функция заполнения массива случайными числами
{
for(int i = 0; i < matr.GetLength(0); i++)
 {
    for(int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(9,100);
    }
 }
 return;
}

void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
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

int line = Promt("введите количество строк ");

int column = Promt("введите количество столбцов ");

int[,] matr = new int[line, column];
FillArray(matr);
PrintArray(matr);
Console.WriteLine();

SelectionSort(matr);
Console.WriteLine();

Console.WriteLine("Массив с упорядоченными значениями->");
PrintArray(matr);








