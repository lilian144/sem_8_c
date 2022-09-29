// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = new int[4,4];

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

void SumElements(int[,] matr)
{
    int result = 0;
    int prevSum = 0;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i,j];
        }

        // Console.WriteLine($"{i + 1}: {sum}");

        if(prevSum == 0)
        {
            prevSum = sum;
        }
        else if(sum < prevSum) 
        {
            prevSum = sum;
            result = i;
        }
    }
    Console.WriteLine($"{result + 1} строка");
}

FillArray(matrix);
PrintArray(matrix);
SumElements(matrix);