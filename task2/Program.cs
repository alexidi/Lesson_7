﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
Console.Clear();

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

 int Akkerman(int n, int m)
{
if (n == 0) return m + 1;
if (m == 0) return Akkerman(n - 1, 1);
return Akkerman(n - 1, Akkerman(n, m - 1));
}
Console.Write($"{Akkerman(n,m)}");
