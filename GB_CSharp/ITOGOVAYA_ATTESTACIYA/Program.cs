/*
Задача 1: 
Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.

Пример:
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"

***************
РЕШЕНИЕ:
***************
*/

// void OutputOfDigits(int m, int n)
// {
//     if (m > n)
//     {
//         return;
//     }
//     Console.Write($"{m} ");
//     OutputOfDigits(m + 1, n);
// }

// Console.Clear();

// OutputOfDigits(4, 8);



/*
Задача 2: 
Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.

Пример:
m = 2, n = 3 -> A(m,n) = 29

***************
РЕШЕНИЕ:
***************
*/

// int AckermannFunction(int n, int m)
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     else if (n != 0 && m == 0)
//     {
//         return AckermannFunction(n - 1, 1);
//     }
//     else
//     {
//         return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
//     }
// }

// Console.Clear();

// Console.Write(AckermannFunction(2, 3));


/*
Задача 3: 
Задайте произвольный массив. 
Выведете его элементы, начиная с конца. 
спользовать рекурсию, не использовать циклы.

Пример:
[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

***************
РЕШЕНИЕ:
***************
*/

void PrintInvertedArray(int[] array, int size)
{
    if (size < 1)
    {
        return;
    }
    Console.Write($"{array[size - 1]} ");
    PrintInvertedArray(array, size - 1);
}

int[] array = [1, 2, 5, 0, 10, 34];
PrintInvertedArray(array, array.Length);