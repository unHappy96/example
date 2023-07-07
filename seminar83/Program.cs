/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

int[,] CompositionOfMatrix(int[,] matrix1, int[,] matrix2){

    int sum = 0;
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0)){
        for (int i = 0; i < matrix1.GetLength(0); i++){
            for (int j = 0; j < matrix2.GetLength(1); j++){
                for (int k = 0; k < matrix1.GetLength(1); k++){
                    sum = sum + matrix1[i,k]*matrix2[k,j];
                }
                newMatrix[i,j] = sum;
                sum = 0;
            }
        }
    } else {
        Console.WriteLine("Ошибка: число столбцов первой матрицы не равно числу строк второй матрицы");
    }
    return newMatrix;
}
//----------------------------------

Console.WriteLine("Первая матрица");
int rows1 = ReadInt("Введите количество строк: ");
int cols1 = ReadInt("Ведите количество столбцов: ");
Console.WriteLine("Вторая матрица");
int rows2 = ReadInt("Введите количество строк: ");
int cols2 = ReadInt("Ведите количество столбцов: ");
int[,] matrix1 = FillMatrix(rows1, cols1, 0, 9);
int[,] matrix2 = FillMatrix(rows2, cols2, 0, 9);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(CompositionOfMatrix(matrix1, matrix2));