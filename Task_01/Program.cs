// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива

void Task01()
{
    int size = 12;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    // int sum = PositiveSum(array);
    // Console.Write($"Сумма положительных элементов массива: {sum})");
    Console.WriteLine($"Сумма положительных элементов массива: {PositiveSum(array)}");
    Console.WriteLine($"Сумма отрицательных элементов массива: {NegativeSum(array)}");

}
Task01();

void FillArray(int[] array, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }

}

void PrintArray(int[] array)
{
    Console.Write("Задан массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int PositiveSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int NegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}