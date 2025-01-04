// ****************************************************************************************************
// Задача 1. 
// Задача 1: Задайте двумерный массив символов (тип char[,]). 
// Создать строку из символов этого массива. 
// Пример
// a b c => “abcdef”
// d e f 

// ***************
// РЕШЕНИЕ:
// ***************

// char[,] array = {
//     {'a','b','c'},
//     {'d','e','f'}
// };

// string str = "";

// foreach (var item in array)
// {
//     str += item;
// }

// Console.WriteLine($"Получившаяся строка из символов массива: {str}");

// ****************************************************************************************************
// Задача 2. 
// Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 

// Пример
// “aBcD1ef! -” => “abcd1ef! -” 

// ***************
// РЕШЕНИЕ:
// ***************


// char[] FromStringToArray(string input)
// {
//     char[] array = new char[input.Length];

//     for (int i = 0; i < input.Length; i++)
//     {
//         array[i] = input[i];
//     }

//     return array;
// }

// string FromArrayToString(char[] array)
// {
//     string letters = "";

//     foreach (char item in array)
//     {
//         letters += item;
//     }

//     return letters;
// }

// char[] ChangeFromBigToSmall(char[] array)
// {
//     string small = "abcdefghijklmnopqrstuvwxyz";
//     string big = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

//     for (int i = 0; i < array.Length; i++)
//     {
//         bool flag = false;
//         int count = 0;

//         foreach (char item in big)
//         {
//             if (array[i] == item)
//             {
//                 flag = true;
//                 break;
//             }

//             count++;
//         }

//         if (flag)
//         {
//             array[i] = small[count];
//         }
//     }

//     return array;
// }

// Console.WriteLine("Введите латинские буквы в разных регистрах:");
// string letters = Console.ReadLine()!;

// Console.WriteLine("\nПреобразованная строка (заглавные буквы заменены на строчные):");
// Console.WriteLine(FromArrayToString(ChangeFromBigToSmall(FromStringToArray(letters))));


// ****************************************************************************************************
// Задача 3. 
// Задайте произвольную строку. Выясните, является ли она палиндромом.
// Пример:
// “aBcD1ef! -” => Нет
// “шалаш” => Да
// “55655” => Да

// ***************
// РЕШЕНИЕ:
// ***************

// char[] FromStringToArray(string input)
// {
//     char[] array = new char[input.Length];

//     for (int i = 0; i < input.Length; i++)
//     {
//         array[i] = input[i];
//     }

//     return array;
// }


// bool IsPalindrom(char[] str)
// {
//     for (int i = 0; i < str.Length; i++)
//     {
//         if (str[i] != str[str.Length - i - 1])
//         {
//             return false;
//         }
//     }
//     return true;
// }


// void PrintResult(bool flag)
// {
//     Console.WriteLine(flag ? "Да" : "Нет");
// }

// Console.WriteLine("Введите произвольную строку. Проверим, является ли она палиндромом:");
// string str = Console.ReadLine()!;

// Console.WriteLine("\nПроверяем строку! Ответ: ");
// PrintResult(IsPalindrom(FromStringToArray(str)));

// ****************************************************************************************************
// Задача 4. 
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.
// Пример:
// “Hello my world” => “world my Hello”

// ***************
// РЕШЕНИЕ:
// ***************

// string[] SplitString(string input)
// {
//     string[] answer = new string[CountString(input)];
//     int count = 0;
//     string result = "";

//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ' ')
//         {
//             answer[count] = result;
//             result = "";
//             count++;
//         }
//         else
//         {
//             result += input[i];
//         }
//     }
//     answer[count] = result;
//     return answer;
// }

// int CountString(string input)
// {
//     int count = 1;

//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ' ')
//         {
//             count++;
//         }
//     }

//     return count;
// }

// string[] RevertsSentence(string[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         (array[array.Length - 1 - i], array[i]) = (array[i], array[array.Length - 1 - i]);
//     }

//     return array;
// }

// void PrintArray(string[] array)
// {
//     foreach (string item in array)
//     {
//         Console.Write($"{item} ");
//     }
// }

// Console.WriteLine("Введите предложение");
// string sentence = Console.ReadLine()!;
// Console.WriteLine("Первёрнутое предложение:");
// PrintArray(RevertsSentence(SplitString(sentence)));