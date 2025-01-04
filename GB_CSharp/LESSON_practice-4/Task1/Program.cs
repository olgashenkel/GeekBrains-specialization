// Задание 1. Совместная работа
// Задайте одномерный массив, заполненный случайными числами. 
// Вывести массив на экран.
// Примеры
// [1 3 4 19 3] 
// [4 3 4 1 9 5 21 13]
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
        Console.Write(item + " ");
    }
}

Console.WriteLine("Input min value");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value");
int maximum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input size value");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(minimum, maximum, length);
ShowArray(array);