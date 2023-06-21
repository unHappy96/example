/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
int[] array = new int[2];

for (int i=0; i<2; i++){
    Console.WriteLine($"Введите {i+1} число:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int MyPow(int arg1, int arg2) {
    int i = 0;
    int result = 1;
    while (i<arg2) {
        result = result*arg1;
        i++;
    }
    return result;
}

Console.WriteLine(MyPow(array[0], array[1]));