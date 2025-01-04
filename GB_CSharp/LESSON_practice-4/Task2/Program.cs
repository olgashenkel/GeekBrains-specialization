// Задание 2. Работа в сессионных залах
// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
// Найдите количество нечетных чисел в массиве.
// Пример
// [1 5 11 21 81 4 0 91 2 3] => 7
// ***************
// РЕШЕНИЕ:
// ***************


int[] CreateRandomArray(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}

int CountOfOdd(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item % 2 != 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Input min value");
int minimum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input max value");
int maximum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input length value");
int length = int.Parse(Console.ReadLine()!);

int[] array = CreateRandomArray(minimum, maximum, length);
ShowArray(array);

int count = CountOfOdd(array);
Console.WriteLine($"\nCount of odd numbers is array is {count}");
