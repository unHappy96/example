/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

void PrintArray(double[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

double[] ColAverage(int[,] matrix){

    double[] array = new double[matrix.GetLength(1)];
    double sum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++){
        sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++){

            sum = sum + matrix[i,j];

        }
        array[j] = Math.Round(sum/matrix.GetLength(0), 1);
    }

    return array;
}

// -----------------

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Ведите количество стобцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 9);
PrintMatrix(matrix);
PrintArray(ColAverage(matrix));