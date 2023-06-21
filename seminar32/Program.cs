/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int[] A = new int[3];
int[] B = new int[3];
double result = 0;

Console.WriteLine("Введите координаты первой точки");
A[0] = Convert.ToInt32(Console.ReadLine());
A[1] = Convert.ToInt32(Console.ReadLine());
A[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
B[0] = Convert.ToInt32(Console.ReadLine());
B[1] = Convert.ToInt32(Console.ReadLine());
B[2] = Convert.ToInt32(Console.ReadLine());

result = Math.Sqrt(Math.Pow(B[0]-A[0], 2)+Math.Pow(B[1]-A[1], 2)+Math.Pow(B[2]-A[2], 2));

Console.WriteLine($"Расстояние между точками: {Math.Round(result, 2)}");
