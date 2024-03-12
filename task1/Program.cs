// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

Console.Clear();
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

void digits(int m, int n)
{
    if (m + 1 < n)
    {
        digits(n - 1, m);
        Console.Write($"{n - 1} ");
    }
    else if (n + 1 < m)
    {
        digits(n, m - 1);
        Console.Write($"{m - 1} ");
    }
    else if (m == n)
    {
        Console.WriteLine("Введите разные числа!");
    }
}
if (m+1 == n || m-1 == n)
    {
        Console.WriteLine("Введите числа с разницей больше чем 1!");
    }
digits(m, n);
