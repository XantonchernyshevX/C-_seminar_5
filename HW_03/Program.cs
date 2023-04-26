// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива


Console.Clear();
int size = 12;
double[] array = new double[size];
FillArray(array);
PrintArray(array);
FindDiffMaxMin(array);

void FillArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 20 - 10;      // интервал от -10 до 10
    }
}

void PrintArray(double[] array)
{
    Console.Write("Задан массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:F2} ");       // два знака после запятой
    }
    Console.WriteLine();
}

void FindDiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        diff = max - min;

    }
    Console.WriteLine("Максимальное число в массиве: {0:0.00}", max);  // два знака после запятой (другой способ)
    Console.WriteLine("Минимальное число в массиве: {0:0.00}", min);
    Console.Write($"Разница между максимальным и минимальным элементами массива: {diff:F2}");
}