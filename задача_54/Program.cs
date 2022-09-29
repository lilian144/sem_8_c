// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] matrix = new int[3,4];

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void IncreasingArray(int[,] matr)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int m = 0; m < matrix.GetLength(1) - 1; m++)
            {
                if(matrix[i,m] > matrix[i, m + 1])
                {
                    int res = matrix[i, m + 1];
                    matrix[i, m + 1] = matrix[i,m];
                    matrix[i,m] = res;
                }
            }
        }
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("-------");
IncreasingArray(matrix);
PrintArray(matrix);