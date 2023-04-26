// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

void Task03()
{
    int size = 16;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    FindElement(array, number);
}
Task03();

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

// void FindElement(int[] array, int number)
// {
//     bool flag = false;
//     int index = -1;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             flag = true;
//             index = i;
//         }
//     }
//     if (flag)
//     {
//         Console.Write($"Заданное число находится на {index} позиции");
//     }
//     else
//     {
//         Console.Write("Заданного числа нет в массиве");
//     }
// }

void FindElement(int[] array, int number)
{
    bool flag = false;
    int index = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            flag = true;
            index = i;
        }
    }
    if (flag)
    {
        Console.Write($"Заданное число находится на позиции: {index}");
    }
    else
    {
        Console.Write("Заданного числа нет в массиве");
    }
}