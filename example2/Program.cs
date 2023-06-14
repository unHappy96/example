// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 3 числа: ");

double numberA = Convert.ToDouble(Console.ReadLine());
double numberB = Convert.ToDouble(Console.ReadLine());
double numberC = Convert.ToDouble(Console.ReadLine());
double max = 0;

if (numberA >= numberB && numberA >= numberC) {
    max  = numberA;
    Console.WriteLine($"Максимальное число =  {max}");
}
else if (numberB >= numberA && numberB >= numberC) {
    max = numberB;
    Console.WriteLine($"Максимальное число =  {max}");
}
else if (numberC >= numberA && numberC >= numberB) {
    max = numberC;
    Console.WriteLine($"Максимальное число =  {max}");
}
