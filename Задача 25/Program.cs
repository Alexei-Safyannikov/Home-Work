// Напишите цикл, 
// который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243

// 2, 4 -> 16

Console.WriteLine("Введите первое число А");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число B");
int numberB = Convert.ToInt32(Console.ReadLine());
int res = 1;
int count = 1;
if (numberB > 1)
{
    while (numberB >= count)
    {
        res = numberA * res;
        count++;
    }
    Console.WriteLine($"Число {numberA} в степени {numberB} = {res}");
}
else Console.WriteLine("Ошибка.Введите натуральную степень");
