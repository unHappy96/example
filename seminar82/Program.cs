/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int ReadInt(string text)
{

    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());

}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{

    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {

        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {

            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);

        }
    }

    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{

    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {

        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {

            System.Console.Write(matrixForPrint[i, j] + "\t");

        }

        System.Console.WriteLine();
    }
}

int RowWithMinSumEl(int[,] matrix){

    int minSum = 0;
    int sum = 0;
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            sum = sum + matrix[i,j];
        }
        if (minSum == 0){
            minSum = sum;
        }
        if (sum < minSum){
            minSum = sum;
            minRow = i;
        }
        sum = 0;
    }
    return minRow+1;
}

//----------------------------------

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Ведите количество стобцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine(RowWithMinSumEl(matrix));