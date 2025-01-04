// Задача 4. 
// Задайте двумерный массив из целых чисел. 
// Сформируйте новый одномерный массив, состоящий 
// из средних арифметических значений по строкам двумерного массива.
// Пример:
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4
// ***************
// РЕШЕНИЕ:
// ***************


int[,] Create2dArray(int min, int max, int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] AverageArray(int[,] array)
{
    int[] array2 = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        array2[i] = sum / array.GetLength(1);
    }
    return array2;
}

Console.WriteLine("Введите минимальное значение массива: ");
int minimum = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение массива: ");
int maximum = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите колличество строк массива: ");
int rows1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int cols1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Исходный массив: ");
int[,] matrix = Create2dArray(minimum, maximum, rows1, cols1);
Show2dArray(matrix);


Console.WriteLine("\nНовый массив, состоящий из средних арифметических значений по строкам двумерного массива: ");
int[] array = AverageArray(matrix);
foreach (int item in array)
{
    Console.Write($"{item} ");
}