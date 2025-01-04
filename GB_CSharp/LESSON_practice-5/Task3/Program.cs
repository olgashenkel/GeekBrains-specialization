// Задайте двумерный массив. Найдите сумму элементов, находящихся 
// на главной диагонали (с индексами (0,0); (1; 1) и т.д.
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

int Sum(int[,] array)
{
    int sum = 0;
    int count = 0;
    if (array.GetLength(0) < array.GetLength(1))
    {
        count = array.GetLength(0);
    }
    else
    {
        count = array.GetLength(1);
    }
        for (int i = 0; i < count; i++)
        {
            sum += array[i, i];
        }
        return sum;
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

Console.WriteLine($"\nСумма элементов, находящихся на главной диагонали = {Sum(array2)}");
