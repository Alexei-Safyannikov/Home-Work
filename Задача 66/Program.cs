// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Sum(int num1, int num2)
{
    if(num1==num2) return 1;
    else return num1 + Sum (num1 + 1, num2);
}

int sum = Sum(numberA, numberB);
Console.WriteLine($"M = {numberA}; N = {numberB} -> {sum}");