// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами



Console.Clear();
int size = 12;
int[] array = new int[size];
FillArray (array);
PrintArray(array);
SumOddNumbers(array);

void FillArray (int[] array, int minValue = -10, int maxValue = 10)
// задал такой интервал, чтобы сумма была не очень большой
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
        Console.Write($"{array [i]} ");
    }
    Console.WriteLine();
}

void SumOddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    Console.Write("Сумма элементов с нечетными индексами: ");
    Console.WriteLine(sum);
}