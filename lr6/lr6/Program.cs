first();
second();
void first()
{
    int sum = 0;
    Console.Write("Введите длинну массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
    Console.WriteLine("Введите элементы массива");
    for (int i = 0; i < n; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 1; i < arr.Length - 1; i++)
    {
        sum += arr[i];
    }
    Console.WriteLine($"Сумма элемнтов массива: {sum}");
}
void second()
{
    int num = 0;
    Console.Write("Введите кол-во строк массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] arr = new int[n, m];
    Console.WriteLine("Введите элементы массива");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[j, i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    for (int i = 0; i < m; i++)
    {
        bool zero = false;
        for (int j = 0; j < n; j++)
        {
            if (arr[j, i] == 0)
                zero = true;
        }
        if (zero == true)
            num++;
    }
    Console.WriteLine($"Кол-во столбцов, содержащие ноль: {num}");
}