// Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if(number>=100)
{
    while(number>=999)
    {
        number = number/10;
    }
    number = number % 10;
    Console.WriteLine($"Третья цифра числа --> {number}");
}
else Console.WriteLine("Третьей цифры нет");