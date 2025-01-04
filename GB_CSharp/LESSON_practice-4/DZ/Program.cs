// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ // или при вводе числа, 
// сумма цифр которого чётная.
// ***************
// РЕШЕНИЕ:
// ***************

// int GetSumOfDigits(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum += num % 10;
//         num /= 10;
//     }
//     return sum;
// }

// bool IsInputDigit(string number)
// {
//     bool flag = false;
//     foreach (char e in number)
//     {
//         if (char.IsAsciiDigit(e) == true)
//         {
//             flag = true;
//         }
//     }
//     return flag;
// }

// Console.WriteLine("Введите любое целое число. Программа завершит свою работу при вводе символа 'q' или если сумма цифр числа окажется четной:");

// while (true)
// {
//     string input = Console.ReadLine()!;

//     if (input == "q")
//     {
//         Console.WriteLine("Вы ввели 'q'. Программа завершена.");
//         break;
//     }
//     if (IsInputDigit(input))
//     {
//         int SumOfDigits = GetSumOfDigits(int.Parse(input));
//         if (SumOfDigits % 2 == 0)
//         {
//             Console.WriteLine("Вы ввели число, сумма цифр которого является четной. Программа завершена.");
//             break;
//         }
//     else
//     {
//         Console.WriteLine("Попробуйте еще раз! Введите любое целое число или символ 'q' для выхода:");
//     }   
//      }

// }



// ****************************************************************************************************

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// ***************
// РЕШЕНИЕ:
// ***************

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// int CountOfEven(int[] array)
// {
//     int count = 0;
//     foreach (int item in array)
//     {
//         if (item % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// void ShowArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         Console.Write($"{item} ");
//     }
// }

// Console.WriteLine("Введите размер массива:");
// int length = int.Parse(Console.ReadLine()!);

// int[] array = CreateRandomArray(length);
// int count = CountOfEven(array);
// ShowArray(array);
// Console.WriteLine($"\nКоличество четных чисел в массиве: {count}. Проверено {length} чисел");



// ****************************************************************************************************

// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)
// ***************
// РЕШЕНИЕ:
// ***************

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
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

int[] GetInvertedArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        (array[array.Length - 1 - i], array[i]) = (array[i], array[array.Length - 1 - i]);
    }
    return array;
}

Console.WriteLine("Введите размер массива:");
int length = int.Parse(Console.ReadLine()!);
int[] array = CreateRandomArray(length);
Console.WriteLine("Исходный массив:");
ShowArray(array);

int[] array2 = GetInvertedArray(array);
Console.WriteLine($"\n\nМассив после преобразования (перевернутый):");
ShowArray(array2);

// ****************************************************************************************************