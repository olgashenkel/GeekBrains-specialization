// ЗАДАЧА 1. Верните элемент из массива по позиции
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет: "Позиция по рядам выходит за пределы массива" или
// "Позиция по колонкам выходит за пределы массива"
// Позиции в массиве считать от единицы.
// В коде, начальные условия:
// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// int x = 2;
// int y = 2;
// Выводится: 6

// ***************
// РЕШЕНИЕ:
// ***************


// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//     // и возвращает значение этого элемента или же указание, что такого элемента нет.

//     // Поиск элемента по позициям
//     public static int FindElementByPosition(int[,] array, int x, int y)
//     {
//         return array[x - 1, y - 1];
//     }

//     // Проверка позиций на вхождение в массив
//     public static bool ValidatePosition(int[,] array, int x, int y)
//     {
//         if (x <= 0 || x > array.GetLength(0))
//         {
//             Console.WriteLine("Позиция по рядам выходит за пределы массива");
//             return false;
//         }
//         if (y <= 0 || y > array.GetLength(1))
//         {
//             Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//             return false;
//         }
//         return true;
//     }

//     public static void PrintResult(int[,] numbers, int x, int y)
//     {
//         if (ValidatePosition(numbers, x, y))
//         {
//             Console.WriteLine(FindElementByPosition(numbers, x, y));
//         }
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] array;

//         int x, y;

//         if (args.Length >= 3)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             array = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         array[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }

//             // Парсинг x и y из аргументов
//             if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
//             {
//                 // Теперь у вас есть двумерный массив "array" и координаты x и y
//                 UserInputToCompileForTest.PrintResult(array, x, y);
//             }
//             else
//             {
//                 Console.WriteLine("Error parsing x or y to an integer.");
//             }
//         }
//         else
//         {

//             // Если аргументов на входе нет, используем примерный массив
//             array = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//             x = 3;
//             y = 4;

//             UserInputToCompileForTest.PrintResult(array, x, y);

//         }
//     }
// }



// ****************************************************************************************************
// ЗАДАЧА 2. Поменяйте местами первую и последнюю строку массива
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
// Начальные условия:
// int[,] numbers = new int[,]
// {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// Выводится:
// 9   10  11  12
// 5   6   7   8
// 1   2   3   4

// ***************
// РЕШЕНИЕ:
// ***************

// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Печать массива
//     public static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write($"{array[i, j]}\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     // Обмен первой с последней строкой
//     public static int[,] SwapFirstLastRows(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             SwapItems(array, i);
//         }
//         return array;
//     }

//     // Обмен элементами массива
//     public static void SwapItems(int[,] array, int i)
//     {
//         int temp = array[0, i];
//         array[0, i] = array[array.GetLength(0) - 1, i];
//         array[array.GetLength(0) - 1, i] = temp;
//     }

//     public static void PrintResult(int[,] numbers)
//     {
//         PrintArray(SwapFirstLastRows(numbers));
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив
//             numbers = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }


// ****************************************************************************************************
// ЗАДАЧА 3. Строка с наименьшей суммой элементов
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Начальные условия:
// // Начальные условия
// int[,] numbers = new int[,] {
//     {1, 2, 3},
//     {1, 1, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };
// Выводится: 1

// ***************
// РЕШЕНИЕ:
// ***************

// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     /// Вычисление сумм по строкам (на выходе массив с суммами строк)
//     public static int[] SumRows(int[,] array)
//     {
//         int[] sum = new int[array.GetLength(0)];
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 sum[i] += array[i, j];
//             }
//         }
//         return sum;
//     }

//     // Получение индекса минимального элемента в одномерном массиве
//     public static int MinIndex(int[] array)
//     {
//         int minI = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[minI] > array[i])
//             {
//                 minI = i;
//             }
//         }
//         return minI;
//     }
//     public static void PrintResult(int[,] numbers)
//     {
//         int[] sums = SumRows(numbers);
//         int minIndex = MinIndex(sums);
//         Console.Write(minIndex);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив

//             numbers = new int[,] {
//                 {1, 2, 3},
//                 {1, 1, 0},
//                 {7, 8, 2},
//                 {9, 10, 11}
//     };
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }



// ****************************************************************************************************
// ЗАДАЧА 4. 
// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца.

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
            Console.Write($"{array[i, j]}\t");
        }

        Console.WriteLine();
    }
}

int[] MinElementCoordinates(int[,] array)
{
    int min = array[0, 0];
    int[] min_coordinates = new int[2];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                min_coordinates[0] = i;
                min_coordinates[1] = j;
            }
        }
    }

    return min_coordinates;
}

int[,] SwapElementsRow(int[,] array)
{
    for (int i = MinElementCoordinates(array)[0]; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            (array[i + 1, j], array[i, j]) = (array[i, j], array[i + 1, j]);
        }
    }

    return array;
}

int[,] SwapElementsCol(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = MinElementCoordinates(array)[1]; j < array.GetLength(1) - 1; j++)
        {
            (array[i, j + 1], array[i, j]) = (array[i, j], array[i, j + 1]);
        }
    }

    return array;
}

int[,] New2dArray(int[,] array)
{
    int[,] new_array = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < new_array.GetLength(0); i++)
    {
        for (int j = 0; j < new_array.GetLength(1); j++)
        {
            new_array[i, j] = array[i, j];
        }
    }

    return new_array;

}

Console.WriteLine("Введите минимальное значение массива:");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение массива:");
int max = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива:");
int cols = int.Parse(Console.ReadLine()!);

int[,] matrix = Create2dArray(min, max, rows, cols);
Console.WriteLine("Исходный массив:");
Show2dArray(matrix);

Console.WriteLine("\nНовый массив:");
Show2dArray(New2dArray(SwapElementsRow(SwapElementsCol(matrix))));