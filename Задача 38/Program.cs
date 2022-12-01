//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Задайте длину массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте минимальное число массива");
int minArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте максимальное число массива");
int maxArray = Convert.ToInt32(Console.ReadLine());

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;//создаем случайные вещественные числа
        array[i] = Math.Round(num, 1); // округляем результат до 1 цифры после запятой
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double DifferenceNumberMin(double[] array)
{
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}

double DifferenceNumberMax(double[] array)
{
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}

double[] arr = CreateArrayRndDouble(sizeArray, minArray, maxArray);
PrintArray(arr);

double differenceNumberMin = DifferenceNumberMin(arr);
double differenceNumberMax = DifferenceNumberMax(arr);
double res = differenceNumberMax - differenceNumberMin;
res = Math.Round(res, 1);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {res}");