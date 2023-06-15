// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");

int value = Convert.ToInt32(Console.ReadLine());
int size = value.ToString().Length;
int result = 0;

if (size == 3) {
    result = value%10;
    Console.WriteLine(result);
}
else if (size < 3) {
    Console.WriteLine("Третьей цифры нет");
}
else if (size > 3) {
    while (size != 3) {
        value = value / 10;
        size--;
    }
    result = value%10;
    Console.WriteLine(result);
}