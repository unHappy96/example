/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int ReadInt(string text)
{

    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());

}

int[,,] FillArray(int page, int row, int col, int leftRange, int rightRange)
{

    int[,,] array = new int[page, row, col];
    Random rand = new Random();

    for (int k = 0; k < array.GetLength(0); k++)
    {

        for (int i = 0; i < array.GetLength(1); i++)
        {

            for (int j = 0; j < array.GetLength(2); j++)
            {
                array[k, i, j] = rand.Next(leftRange, rightRange + 1);
            }
        }
    }

    return array;
}

void PrintArray(int[,,] arrayForPrint)
{
    for (int k = 0; k < arrayForPrint.GetLength(0); k++)
    {
        for (int i = 0; i < arrayForPrint.GetLength(1); i++)
        {

            for (int j = 0; j < arrayForPrint.GetLength(2); j++)
            {
                System.Console.Write(arrayForPrint[i, j, k] + $"({i},{j},{k})" + "\t");
            }

            System.Console.WriteLine();
        }
    }
}

int[,,] ArrayNonRepeatingNums(){

    int[,,] myArray = new int[2,2,2];
    int count = 1;
    while (count != 0) {
        int[,,] array = FillArray(2, 2, 2, 10, 99);
        int n = 0;

        for (int kk = 0; kk < array.GetLength(0); kk++)
        {
            for (int jj = 0; jj < array.GetLength(2); jj++)
            {
                for (int ii = 0; ii < array.GetLength(1); ii++)
                {
                    for (int k = 0; k < array.GetLength(0); k++)
                    {

                        for (int j = 0; j < array.GetLength(2); j++)
                        {

                            for (int i = 0; i < array.GetLength(1); i++)
                            {
                                if (array[ii, jj, kk] == array[i, j, k] && (ii, jj, kk) != (i, j, k))
                                {
                                    
                                    n=n+1;

                                }
                            }
                        }
                    }
                }
            }
        }
        if (n == 0){
            myArray = array;
            count = count - 1;
        }
    }
    return myArray;
}

//----------------------------------

PrintArray(ArrayNonRepeatingNums());


/* using System.Diagnostics;

Stopwatch sw = Stopwatch.StartNew();
for (int i = 0; i < 100; i++)
{

}
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds); */