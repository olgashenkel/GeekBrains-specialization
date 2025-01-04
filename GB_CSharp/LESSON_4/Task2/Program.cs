// Задача 2. Требуется сформировать двумерный массив из целых чисел и вывести на
// экран элементы, которые удовлетворяют некоторому критерию. Под этим
// критерием будем понимать чётность суммы цифр у числа.
// ***************
// РЕШЕНИЕ:
// ***************


int[,] CreateMatrix(int rowsCount, int columsCount)
{
    int[,] matrix = new int[rowsCount, columsCount];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);

foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
    {
        Console.WriteLine($"{e} ");
    }
}

bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}
 
int GetSumOfDigits(int value)
{
    int sum = 0;
    while(value>0)
    {
        sum += value%10;
        value /= 10;
    }
    return sum;
}

