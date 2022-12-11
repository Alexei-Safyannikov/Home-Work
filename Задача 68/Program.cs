// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int AckermanFunctions( int numM, int numN)
{
    if(numM==0) return numN+1;
    if(numN==0) return AckermanFunctions(numM-1,1);
    return AckermanFunctions(numM-1, AckermanFunctions(numM,numN-1));
}

int ackerman = AckermanFunctions(numberM,numberN);
Console.WriteLine($"A(n,m)-{ackerman}");

