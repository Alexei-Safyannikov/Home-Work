// На вход принимает 2 числа
// Выдает Max и Min
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2) 
{
    Console.WriteLine($"Max = {number1} Min = {number2}");
}
else Console.WriteLine ($"Min = {number1} Max = {number2}");