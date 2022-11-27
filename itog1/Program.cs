// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные 
//натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Promt(string msg)
{
    Console.Write(msg);
    int temp = Convert.ToInt32(Console.ReadLine());
    return temp;
}

int NaturalChetNumber(int n, int m)
{
    for (int i = n; i <= m; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
return n; 
}

int n = Promt("Введите n: ");
int m = Promt("Введите m: ");;
Console.WriteLine(NaturalChetNumber(n, m));