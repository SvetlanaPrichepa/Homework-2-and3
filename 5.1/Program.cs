// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int PromtInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine()); 
    return temp;                                     
}

int[] CreateArray(int length, int min, int max)
{
    int[] tempArray  = new int[length];     
    for(int i = 0; i < length; i++)                                       
    {
        tempArray[i] = new Random().Next(min, max);
    }
    return tempArray;
}

int CountChet(int[] array)                            
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    System.Console.Write($"{array[0]}");
    for(int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
        
    }

}

            
int length = 6;
int min = 100;
int max = 999;
int[] array = CreateArray(length, min, max);
PrintArray(array);
Console.WriteLine();

Console.Write("Четных чисел в массиве: ");
Console.Write(CountChet(array)); 
