// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

/*A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int x1 = ReadInt("Введите X1: ");
int y1 = ReadInt("Введите Y1: ");
int m1 = ReadInt("Введите M1: ");
int x2 = ReadInt("Введите X2: ");
int y2 = ReadInt("Введите Y2: ");
int m2 = ReadInt("Введите M2: ");

int A = x2 - x1;
int B = y2 - y1;
int C = m1 - m2;
double length = Math.Sqrt(A * A + B * B + C * C);

Console.WriteLine($"Расстояние {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}