// Задание. Генерация случайных чисел.
// ***************
// РЕШЕНИЕ:
// ***************

// Random rnd = new Random();

// int size = 100;
// int[] arr_int = new int[size];
// int i = 0;
// while (i < size)
// {
//     arr_int[i] = rnd.Next(1, 21);
//     i++;
// }

// i = 0;
// while (i < size)
// {
//     Console.Write($"{arr_int[i]}\t");
//     i++;
// }


// ****************************************************************************************************

// Задание. Ввод данных с клавиатуры.
// ***************
// РЕШЕНИЕ:
// ***************

int size = 10;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    Console.WriteLine("Введите элемент массива с клавиатуры (целое число):");
    int input = int.Parse(Console.ReadLine()!);
    arr_int[i] = input;
    i++;
}

i = 0;
while (i < size)
{
    Console.Write($"\t{arr_int[i]}");
    i++;
}