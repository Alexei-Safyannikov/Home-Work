// Напишите программу, которая 
// принимает на вход цифру, 
// обозначающую день недели, и 
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели и вы узнаете является ли он выходным");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 7 && number >= 1)
{
    if (number <= 5 && number >= 1)
    {
        Console.WriteLine("нет");
    }
    else if (number <= 7 && number >= 6)
    {
        Console.WriteLine("да");
    }
}
else Console.WriteLine("Вы ввели неверное число");