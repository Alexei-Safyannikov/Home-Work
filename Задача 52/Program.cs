// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] ArithmeticMean(int[,] matrix)
{
    int size = matrix.GetLength(1);
    double[] array = new double[size];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            count++;
        }
        sum = sum / count;
        sum = Math.Round(sum, 2);
        array[j] = sum;
    }
    return array;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}.");
    }
}

int[,] matrix = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
double[] n = ArithmeticMean(matrix);
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArray(n);