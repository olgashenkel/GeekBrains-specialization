// Д/З. Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
// Начальные условия:
// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// ***************
// РЕШЕНИЕ:
// ***************

// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Подсчет количества элементов массива, попадающих в заданный диапазон
//     // numbers - массив, в котором ведется подсчет
//     // minRange - минимальная граница диапазона
//     // maxRange - максимальная граница диапазона
//     public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
//     {
//         //Введите сюда свое решение
//         int a = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] >= minRange && numbers[i] <= maxRange)
//             {
//                 a++;
//             }
//         }
//         return a;
//     }

//     public static void PrintResult(int[] array)
//     {

//         //Введите сюда свое решение
//         Console.WriteLine(CountItemsRange(array, 10, 90));

//     }

// }


// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;


//         if (args.Length >= 1)
//         {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();

//             // Теперь arr содержит преобразованные в целые числа из командной строки

//         }
//         else
//         {
//             // Если аргументов на входе нет
//             array = new int[] { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 }; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }


// ****************************************************************************************************
// Д/З. Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет количество чётных чисел в массиве.
// Начальные условия:
// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
// ***************
// РЕШЕНИЕ:
// ***************

// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Подсчет количества четных элементов массива
//     // numbers - массив, в котором ведется подсчет
//     public static int CountEvenItems(int[] numbers)
//     {
//         //Напишите свое решение здесь
//         int even = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] % 2 == 0)
//             {
//                 even++;
//             }
//         }
//         return even;
//     }

//     public static void PrintResult(int[] array)
//     {
//         //Напишите свое решение здесь
//         Console.WriteLine(CountEvenItems(array));


//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;


//         if (args.Length >= 1)
//         {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();

//             // Теперь arr содержит преобразованные в целые числа из командной строки

//         }
//         else
//         {
//             // Если аргументов на входе нет
//             array = new int[] { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 }; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }


// ****************************************************************************************************
// Д/З. Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Начальные условия:
// int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
// ***************
// РЕШЕНИЕ:
// ***************

// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Разница между максимальным и минимальным элементами массива

//     // Нахождение минимума массива
//     public static double FindMin(double[] numbers)
//     {
//         //Напишите свое решение здесь

//         double min = numbers[0];
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] < min)
//             {
//                 min = numbers[i];
//             }
//         }
//         return min;
//     }

//     // Нахождение максимума массива
//     public static double FindMax(double[] numbers)
//     {
//         //Напишите свое решение здесь
//         double max = numbers[0];
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] > max)
//             {
//                 max = numbers[i];
//             }
//         }
//         return max;
//     }



//     public static void PrintResult(double[] array)
//     {
//         //Напишите свое решение здесь

//         double resalt = FindMax(array) - FindMin(array);
//         Console.WriteLine(resalt);

//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         double[] array;


//         if (args.Length >= 1)
//         {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(double.Parse)
//                                   .ToArray();

//             // Теперь arr содержит преобразованные в целые числа из командной строки

//         }
//         else
//         {
//             // Если аргументов на входе нет
//             array = new double[] { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 }; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }


// ****************************************************************************************************
// Д/З. Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен 
// располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.
// Пример
// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]
// ***************
// РЕШЕНИЕ?????:
// ***************

int num = 8741;
int num1 = num;
int size = 1;
int counter = 1;

while (num1 > 0)
{
    num1 /= 10;
    size++;
    counter *= 10;
}

int[] array = new int[size];
for (int i = 0; i <= size; i++)
{
    array[i] = num / (counter / 10) % 10;
    counter /= 10;
    Console.Write($"{array[i]} ");
}


// ****************************************************************************************************
