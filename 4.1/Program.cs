// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B. Реализовать через функции.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В(степень): ");
int B = Convert.ToInt32(Console.ReadLine());


double power(int A, int B)
{
    if (B > 0)  return A*power(A, B-1);
    if (B < 0)  return 1.0 / power(A, -B);
    return 1; // if B == 0
}
Console.WriteLine($"{A} ^ {B} = " + Math.Pow(A, B));
