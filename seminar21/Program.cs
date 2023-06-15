// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число, ");

int value = Convert.ToInt32(Console.ReadLine());

int result = (value%100)/10;
Console.WriteLine(result);
