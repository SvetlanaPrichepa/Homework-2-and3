// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


const int k = 0;
const int b = 1;
const int x = 0;
const int y = 1;

double Promt(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());
}


void InputCoeff(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Коэффициенты  {i + 1}-го уравнения: \n");
        array[i, k] = Promt("Введи k: ");
        array[i, b] = Promt($"Введи b: ");
    }
}

double[] PointCalculator(double[,] coeff)
{
    double[] point = new double[2];
    point[x] = (coeff[1,b] - coeff[0,b]) / (coeff[0,k] - coeff[1,k]);
    point[y] = point[0] * coeff[0,0] + coeff[0,1];
    return point;
}

double[,] coefficient = new double[2,2];

InputCoeff(coefficient);
double[] crossPoint = PointCalculator(coefficient);
Console.WriteLine();
Console.Write($"Точка пересечения: ({crossPoint[x]}, {crossPoint[y]})");
