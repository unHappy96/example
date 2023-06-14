// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число, ");

int number = Convert.ToInt32(Console.ReadLine());
var list = new List<int>();

while (number > 0) {
    if ((number%2)==0){
        list.Add(number);
    }

    number = number - 1;
}

list.ForEach(Console.WriteLine);