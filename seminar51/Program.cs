/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] FillArray(int size, int leftRange, int rightRange)        //функция для создания массива
{
	int[] tempArray = new int[size];
	Random rand = new Random();

	for (int i = 0; i < tempArray.Length; i++)
	{
		tempArray[i] = rand.Next(leftRange, rightRange + 1);
	}

	return tempArray;
}

void PrintArray(int[] arrayForPrint)        //функция вывода массива
{
	System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int EvenNumbers(int [] myarray){                    //функция для нахождения количества четных элементов массива
    int count = 0;
    for (int i = 0; i <myarray.Length; i++){
        if (myarray[i]%2==0){
            count++;
        }
    }
    return count;
}

//--------------------------------------------------------------------------------------

int [] array = FillArray(5, 100, 999);  //создали массив из 5 трехзначных элементов

PrintArray(array); //вывели массив

Console.WriteLine(EvenNumbers(array)); // вывели количество четных элементов массива