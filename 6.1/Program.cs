// Задача 1: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Promt(string msg)
{
    Console.Write(msg);
    int temp = Convert.ToInt32(Console.ReadLine());
    return temp;
}

int[] CreateArray(int length)

{
    int[] tempArray = new int[length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = Promt($"Введите число {i + 1}: ");
    }
    return tempArray;
}

void PrintArray(int[] array)
{
    Console.Write($"{array[0]}");
    for(int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}


int m = Promt("Введи количество чисел: ");
int[] tempArray = CreateArray(m);
PrintArray(tempArray);
Console.WriteLine();
Console.WriteLine($"количество значений больше 0: {CountPositive(tempArray)} ");