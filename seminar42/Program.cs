/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int Summ(int arg) {
    int result = 0;

    while (arg>0) {
        result += arg%10;
        arg = arg/10;
    }

    return result;
}

Console.WriteLine($"Сумма цифр в числе {number} = {Summ(number)}");