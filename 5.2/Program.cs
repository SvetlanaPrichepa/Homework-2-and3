// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Promt(string strMessage)
{
    Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int[] CreateArray(int length)                    
{
    int[] tempArray = new int[length];
    for(int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(-9, 10);
    }
    return tempArray;
}

int Sum(int[] array)                           
{
    int sum = 0;
    for(int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];  
    }
    return sum;
    
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
int[] tempArray = CreateArray(length);
PrintArray(tempArray);
Console.WriteLine();

int sum = Sum(tempArray);
Console.WriteLine($"Cумма элементов, cтоящих на нечётных позициях: {sum} ");
