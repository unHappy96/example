/*  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int ReadInt(string text){

    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int arg1, int arg2){
    if (arg2 == arg1) return arg1;
    else if (arg2 == 0) return 0;
    else return arg2 + Sum(arg1, arg2-1);
}

//-------------

int M = ReadInt("Введите начальное значение M: ");
int N = ReadInt("Введите конечное значение N: ");

Console.WriteLine(Sum(M, N));