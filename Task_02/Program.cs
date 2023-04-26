// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот

void Task02()
{
    int size = 8;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    TurnoverArray(array);
}
Task02();

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

void TurnoverArray(int[] array)
{
    Console.Write("Массив с измененными знаками: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
        Console.Write($"{array[i]} ");
    }
}