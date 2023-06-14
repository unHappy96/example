// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите 2 числа :");
// int numberA = Convert.ToInt32(Console.ReadLine());
// int numberB = Convert.ToInt32(Console.ReadLine());
// int max = 0;
// int min = 0;
double numberA = Convert.ToDouble(Console.ReadLine());
double numberB = Convert.ToDouble(Console.ReadLine());
double max = 0;
double min = 0;

if (numberA > numberB) {
    max  = numberA;
    min  = numberB;
    Console.WriteLine($"Число  {max}, больше чем:  {min}");
}
else if (numberA < numberB) {
    max = numberB;
    min = numberA;
    Console.WriteLine($"Число  {max}, больше чем:  {min}");
}
else {Console.WriteLine("Числа равны");}