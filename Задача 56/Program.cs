// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Задайте кол-во строк массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте кол-во столбцов массива: ");
int num2 = Convert.ToInt32(Console.ReadLine());

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


int[] SearchSumsRow(int[,] matrix)
{
    int[] array = new int[num1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
            array[i] = sum;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.WriteLine($"{array[i]}.");
    }
}

int SmallSum(int[] array)
{
    int num = array[0];
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (num > array[i])
        {
            num = array[i];
            count = i+1;
        }
    }
    return count;
}

int[,] matrix = CreateMatrixRndInt(num1, num2, -9, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[] sumArr = SearchSumsRow(matrix);
PrintArray(sumArr);
int small = SmallSum(sumArr);
Console.WriteLine($"Строка с наименьшей суммой --> {small}");