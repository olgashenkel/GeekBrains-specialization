// Задача 3. Требуется ввести строку с клавиатуры и
// сформировать массив из чисел введенной строки.
// ***************
// РЕШЕНИЕ:
// ***************

string GetLettersFromDigit(string s)
{
    string digit = "";
    foreach(char e in s)
    {
        if(char.IsAsciiDigit(e) == true)
        {
            digit += e;
        }
    }
    return digit;
}

int GetSizeOfArray(int num)
{
    int size = 0;
    while (num > 0)
    {
        num /= 10;
        size++;
    }
    return size;
}

int[] FillArray(int num, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[size - 1 - i] = num % 10;
        num /= 10;
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.Write("]");
}


Console.WriteLine("Введите любые символы и числа:");
string digit = Console.ReadLine()!;
string letters = GetLettersFromDigit(digit);

int number = int.Parse(letters);

Console.WriteLine($"Вывод чисел: {number} в виде массива:");

int size = GetSizeOfArray(number);
int[] arrayFromConsole = FillArray(number, size);
PrintArray(arrayFromConsole);