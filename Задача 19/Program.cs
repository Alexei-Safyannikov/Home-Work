// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int a = number / 10000;
int b = number % 10;
int c = number / 1000;
c = c % 10;
int d = number % 100;
d = d / 10;
if (number < 100000 & number > 9999)
{
    if (a == b)
    {
        if (c == d)
        {
            Console.WriteLine("да");
        }
        else Console.WriteLine("нет");
    }
    else Console.WriteLine("нет");
}
else Console.WriteLine("Введенно некорректное число");