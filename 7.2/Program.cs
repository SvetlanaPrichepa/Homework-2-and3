// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int Promt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for(int i = 0; i < array.GetLength(0); i++)
   {
       for(int j = 0; j < array.GetLength(1); j++)           //создается массив
       {
        array[i,j] = new Random().Next(-9,10);
       } 
   }
  return array;  
}   

void PrintArray(int[,] matr)
{
for(int i = 0; i < matr.GetLength(0); i++)
 {
    for(int j = 0; j < matr.GetLength(1); j++)           //выведение массива на экран
    {
        Console.Write($"{matr[i, j]} ");
    }
   Console.WriteLine("\n"); 
 }
}

void Find(int[,] matr, int line, int column)
{
    if (line < matr.GetLength(0) && column < matr.GetLength(1)) 
{
    Console.WriteLine($"[{line}, {column}] соответствует число {matr[line, column]}"); //нахождение числа в массиве
    return;
}
    Console.WriteLine($"-> такого числа в массиве нет");
} 

int m =Promt(" Количество строк ");
int n = Promt(" Количество столбцов ");
Console.WriteLine();
int[,] array = CreateArray(m, n);
PrintArray(array);
Console.WriteLine();
int line = Promt("Введите индекс строки: ");
int column = Promt("Введите индекс столбца: ");
Find(array, line, column);






