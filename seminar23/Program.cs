// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели");

int value = Convert.ToInt32(Console.ReadLine());

if (value%6==0 || value%7==0) {
    Console.WriteLine("Это выходной день");
} else {
    Console.WriteLine("Это будний день");
}