// Напишите цикл, 
// который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243

// 2, 4 -> 16

Console.WriteLine("Введите первое число А");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число B");
int numberB = Convert.ToInt32(Console.ReadLine());


int Degree(int numA, int numB)
{
    int res = 1;
    for (int count = 1; count <= numB; count++)
    {
        res = numA * res;
    }
    return res;
}
if (numberB > 1)
{
    int degree = Degree(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени {numberB} = {degree}");
}
else Console.WriteLine("Ошибка.Введите натуральную степень");