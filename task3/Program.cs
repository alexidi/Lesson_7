

Console.Clear();
Console.WriteLine("Введите размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = Random_array(new int[n]);

int[] Random_array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 20);
    }
    return array;
}

void Print_array(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}
    Print_array(array);
    Console.WriteLine();

void ElementEndStart(int[] Array, int n)
{
    if (n > 0)
    {
        Console.Write(Array[n] + " ");
        ElementEndStart(Array, n - 1);
    }
    else Console.WriteLine(Array[0]);
}
{
    int[] num = array;
    ElementEndStart(num, num.Length - 1);
}
