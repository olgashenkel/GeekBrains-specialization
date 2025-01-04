// Задание 2. Работа в сессионных залах
// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
// Найдите количество простых чисел в массиве.
// Пример
// [5 11 21 81 4 91 2 3]
// => 4
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

int CountOfPrimes(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (IsPrime(item))
        {
            count++;
        }
    }
    return count;
}

bool IsPrime(int num)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine("Input min value");
int minimum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input max value");
int maximum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input length value");
int length = int.Parse(Console.ReadLine()!);

int[] array = CreateRandomArray(minimum, maximum, length);
ShowArray(array);

int count = CountOfPrimes(array);
Console.WriteLine($"\nПроверено {length} простых чисел заданного массива, из них простых - {count}");
