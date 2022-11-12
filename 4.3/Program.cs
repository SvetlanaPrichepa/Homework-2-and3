//  Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.
//  Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  
//  Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, 
//  “Введите максимальный порог случайных значений”)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 -> 8

int[] CreateArray(int Length = 8)

{
    int[] tempArray = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        tempArray[i] = new Random().Next(minValue: 5, maxValue: 10);   
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    System.Console.Write(value: $"{intArray[0]}");
    for(int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write(value: $", {intArray[i]}");
    }
}

int findMax (int[] intArray)
{
    int tempMax = intArray[0];

    for (int i = 1; i < intArray.Length; i++)
    {
        if (tempMax < intArray[i])
        {
            tempMax = intArray[i];
        }
        else
        {
            if(tempMax <= intArray[i] && intArray[i] != tempMax)
            {
                tempMax = intArray[i];
            }
        }
    }
       return tempMax;
}


System.Console.Write(value: "Массив длиной 8 цифр: ");
int[] maxArray = CreateArray();
printArray(intArray: maxArray);
System.Console.WriteLine(value: $" -> Максимальное число {findMax(intArray: maxArray)}");
