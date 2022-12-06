// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите кол-во вводимых чисел: ");
int number = Convert.ToInt32(Console.ReadLine());


void InputUserNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int SearchPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

if (number > 0)
{
    int[] arr = new int[number];
    InputUserNumbers(arr);
    int res = SearchPositiveNumbers(arr);

    if (res == 1) Console.WriteLine($"{res} --> число больше 0 ввёл пользователь");
    if (res > 1 && res < 5) Console.WriteLine($"{res} --> числа больше 0 ввёл пользователь");
    else if(res>5) Console.WriteLine($"{res} --> чисел больше 0 ввёл пользователь");
}
else Console.WriteLine("Введите число больше 0");