// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();

if (number.ToString().Length !=5){
    Console.WriteLine("Ошибка, вы ввели не пятизначное число");
} 
else if (str[0] == str[str.Length-1] && str[1] == str[str.Length-2]){
    Console.WriteLine("Ваше число палиндром");
} 
else {
    Console.WriteLine("Ваше число не палиндром");
}