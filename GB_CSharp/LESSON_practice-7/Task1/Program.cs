/*
Задание 1.
Напишите программу, которая будет принимать на вход число 
и возвращать сумму его цифр.
Указание: использовать рекурсию.

Пример:
123 => 6
63 => 9

***************
РЕШЕНИЕ:
***************
*/

// int SumOfDigits(int num)
// {
//     if(num == 0)
//     {
//         return 0;
//     }
//     int sum = num % 10 + SumOfDigits(num / 10);
//     return sum;
// }

// Console.Write(SumOfDigits(63));

/*
Задание 2.
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
Указание: Использовать рекурсию. Не использовать цикл.

Пример:
N=5 => 1 2 3 4 5

***************
РЕШЕНИЕ:
***************

*/

// int OutputOfDigits(int num)
// {
//     if (num == 1)
//     {
//         return 1;
//     }
//     Console.Write($"{num} ");
//     return OutputOfDigits(num-1);
// }

// Console.Clear();
// Console.WriteLine("Введите любое натуральное число больше 1:");
// int num1 = int.Parse(Console.ReadLine()!);

// Console.Write(OutputOfDigits(num1));


/*
Считать строку с консоли, содержащую латинские буквы. 
Вывести на экран согласные буквы этой строки.

Указание: Использовать рекурсию. Не использовать цикл.

Пример:
“hello” => h l l
“World” => W r l d
“Hello world!” => H l l w r l d

***************
РЕШЕНИЕ:
***************

*/


void PrintSoql(string letters)
{
    string glasnie = "eyuioa";

    if(letters.Length < 1)
    {
        return;
    }
    
    if (char.IsLetter(letters[0]) && !glasnie.Contains(char.ToLower(letters[0])))   
    {
        Console.Write($"{letters[0]} ");
    }
    PrintSoql(letters.Substring(1));

}


Console.Clear();
Console.WriteLine("Введите любую строку, содержащую латинские буквы:");
string letters = Console.ReadLine()!;

PrintSoql(letters);