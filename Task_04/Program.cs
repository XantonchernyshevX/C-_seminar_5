// Задайте одномерный массив из 10 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]

void Task4()
{
    int size = 12;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    int count = CountElementInSegment(array);
    Console.WriteLine($"Количество элементов из откезка [10, 99] в массиве равно {count}");
}
Task4();

void FillArray(int[] array, int minValue = -100, int maxValue = 100)
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

int CountElementInSegment(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}
