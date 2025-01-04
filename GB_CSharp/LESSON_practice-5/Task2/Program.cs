// Задача 2. Задать двумерный массив. 
// Найти элементы, у которых оба индекса четные. 
// И заменить эти элементы их на квадрат.
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

int[,] MakeSquares(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
    return array;
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
int[,] array2 = Create2dArray(minimum, maximum, rows1, cols1);
Show2dArray(array2);

Console.WriteLine("\nНовый массив: ");
int[,] matrix = MakeSquares(array2);
Show2dArray(matrix);