string[] array1 = new string[] { "computer science", "2222", "world", ":;-)" };
string[] array2 = new string[array1.Length];

void CountArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    if (count == 0)
    {
        Console.WriteLine("Увы! Массив пуст!");
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Исходный массив: ");
PrintArray(array1);

Console.WriteLine("\nНовый массив, содержащий не более трёх символов: ");
CountArray(array1, array2);

PrintArray(array2);