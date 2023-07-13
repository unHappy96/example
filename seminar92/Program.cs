﻿/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int ReadInt(string text){

    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int m, int n){
    if (m == 0) return n+1;
    else if (m > 0 && n == 0) return Akkerman(m-1, 1);
    else return Akkerman(m-1, Akkerman(m, n-1));
}

//-------------

int m = ReadInt("Введите начальное значение m: ");
int n = ReadInt("Введите конечное значение n: ");

Console.WriteLine(Akkerman(m, n));