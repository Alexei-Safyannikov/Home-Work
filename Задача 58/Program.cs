// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Задайте кол-во строк 1-ой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте кол-во столбцов 1-ой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте кол-во строк 2-ой матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте кол-во столбцов 2-ой матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt1(int rows, int columns, int min, int max)
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

int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
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

int[,] MultiplicationMatrix(int[,] matrix, int[,] matrix1)
{

    int[,] matrix2 = new int[matrix.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {

        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix2[i, j] = matrix[i, k] * matrix1[k, j];
                sum += matrix2[i, j];
                //Console.WriteLine($"значение {sum}");
                matrix2[i,j] = sum;
            }

        }
    }
    return matrix2;
}




if (columns1 == rows2)
{
    int[,] matrix1 = CreateMatrixRndInt1(rows1, columns1, 1, 5);
    PrintMatrix(matrix1);
    Console.WriteLine();
    int[,] matrix2 = CreateMatrixRndInt2(rows2, columns2, 1, 5);
    PrintMatrix(matrix2);
    Console.WriteLine();
    int[,] matrix3 = MultiplicationMatrix(matrix1, matrix2);
    PrintMatrix(matrix3);
}
else Console.WriteLine("Перемножить между собой можно матрицы в которых кол-во столбцов первой равно кол-ву строк второй");