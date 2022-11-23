// Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

int index = 1;
void Kub(int n)
{
    while (index <= number)
    {
        Console.WriteLine($"{index,4} {Math.Pow(index, 3),4}");
        index++;
    }
}
if (number > 0)
{
    Kub(number);
}
else Console.WriteLine("Введите число больше 0");
