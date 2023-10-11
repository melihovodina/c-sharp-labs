one();
two();
three();
void one()
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
void two()
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
void three()
{
    int[] arr1 = new int[10];
    int[] arr2 = new int[10];
    int[] arr3 = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < 10; i++)
    {
        arr1[i] = rnd.Next(0, 100);
        arr2[i] = rnd.Next(0, 100);
        arr3[i] = rnd.Next(0, 100);
    }
    Console.WriteLine($"Кол-во нулей в первом массиве: {zero(arr1)}");
    Console.WriteLine($"Кол-во нулей во втором массиве: {zero(arr2)}");
    Console.WriteLine($"Кол-во нулей в третьем массиве: {zero(arr3)}");
}
int zero(int[] arr)
{
    int num = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 0)
            num++;
    }
    return num;
}