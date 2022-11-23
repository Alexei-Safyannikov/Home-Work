// // // Напишите программу, которая 
// // // принимает на вход число и 
// // // выдаёт сумму цифр в числе.

// // // 452 -> 11

// // // 82 -> 10

// // // 9012 -> 12


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int a = 0;
if (number > 1)
{
    while (number > 1)
    {
        a = number % 10;
        sum = sum + a;
        number = number / 10;
    }
}
else if (number < 1)
{
    while (number < -1)
    {
        a = number % 10;
        sum = sum + a;
        number = number / 10;
    }
    sum = sum * -1;
}
else Console.WriteLine("Сумма цифр в числе = 0");
Console.WriteLine($"Сумма цифр в числе = {sum}");