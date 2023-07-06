/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

int[,] SortInDescendingRowsOfMatrix(int[,] matrix)
{
    int oldValue = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            for (int k = j+1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i,j] < matrix[i,k]){
                    oldValue = matrix[i,j];
                    matrix[i,j] = matrix[i,k];
                    matrix[i,k] = oldValue;
                }
            }
        }
    }
    return matrix;
}
//----------------------------------

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Ведите количество стобцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine();
PrintMatrix(SortInDescendingRowsOfMatrix(matrix));