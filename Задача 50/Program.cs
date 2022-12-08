// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого элемента в массиве нет

Console.Write("Введите номер строки двумерного массива: ");
int rowsPosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца двумерного массива: ");
int columnsPosition = Convert.ToInt32(Console.ReadLine());



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine("|");
    }
}

void ItemPosition(int[,] matrix, int rows, int columns)
{
    if (rowsPosition > matrix.GetLength(0) - 1 || columnsPosition > matrix.GetLength(1) - 1) Console.WriteLine($"({rowsPosition},{columnsPosition}) --> такого элемента в массиве нет!");
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (rowsPosition == i && columnsPosition == j)
                {
                    Console.WriteLine($"Значение элемента c позиции массива ({rowsPosition},{columnsPosition}) --> {matrix[i, j]}");
                }
            }
        }
    }
}

if (rowsPosition >= 0 && columnsPosition >= 0)
{
    int[,] matrix = CreateMatrixRndInt(5, 5, -9, 9);
    PrintMatrix(matrix);
    Console.WriteLine();
    ItemPosition(matrix, rowsPosition, columnsPosition);
}
else Console.WriteLine("Введено не верное значение!");