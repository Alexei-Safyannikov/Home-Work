// // // Напишите программу, которая 
// // // принимает на вход число и 
// // // выдаёт сумму цифр в числе.

// // // 452 -> 11

// // // 82 -> 10

// // // 9012 -> 12


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int NumberDigit(int num)
{
    int res = 0;
    int i = 0;
    while (num != 0)
    {
        i = num % 10;
        res = res + i;
        num = num / 10;
    }
    return res < 0 ? res=res*-1 : res;
}
int sum = NumberDigit(number);
Console.WriteLine($"Сумма цифр в числе = {sum}");