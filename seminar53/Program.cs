/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
 */

 double[] FillArray(int size, int leftRange, int rightRange)        //функция для создания массива
{
	double[] tempArray = new double[size];
	Random rand = new Random();

	for (int i = 0; i < tempArray.Length; i++)
	{
		tempArray[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 2);
	}

	return tempArray;
}

void PrintArray(double[] arrayForPrint)        //функция вывода массива
{
	System.Console.WriteLine("[" + string.Join("; ", arrayForPrint) + "]");
}

double FindMaxElem(double[] array){     //функция для нахождения максимального элемента массива

    double max = array[0];
    
    for (int i = 0; i < array.Length; i++){
        if (array[i] > max){
            max = array[i];
        }
    } 
    return max;
}

double FindMinElem(double[] array){        //функция для нахождения минимального элемента массива

    double min = array[0];
    
    for (int i = 0; i < array.Length; i++){
        if (array[i] < min){
            min = array[i];
        }
    } 
    return min;
}

void PrintDiff(double arg1, double arg2){       //функция для вывода разницы между максимальным и минимальным элементов массива
    if (arg2 < 0){
        Console.WriteLine(Math.Round(arg1+arg2, 2));
    } else if (arg2 > 0){
        Console.WriteLine(Math.Round(arg1-arg2, 2));
    }
}
//--------------------------------------------------------------------------------------

double[] array = FillArray(5, -20, 20);  //создали массив из случайных чисел

PrintArray(array); //вывели массив

PrintDiff(FindMaxElem(array), FindMinElem(array)); //вывод разницы между максимальным и минимальным
