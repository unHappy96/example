/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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

int SumUnevenElements(int[] myarray){     //функция для нахождения суммы элементов, стоящих на нечетных позициях
    
    int count = 0;
    for (int i = 0; i < myarray.Length; i++){
        if (i%2!=0){
            count = count + myarray[i];
        }
    }
    return count;
}

//--------------------------------------------------------------------------------------

int [] array = FillArray(5, -20, 20);  //создали массив из случайных чисел

PrintArray(array); //вывели массив

Console.WriteLine(SumUnevenElements(array)); // вывели сумму элементов, стоящих на нечетных позициях