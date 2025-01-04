// 5.4. Задача с гирями/
// нужно найти самую тяжелую гирю
// ***************
// РЕШЕНИЕ:
// ***************

// int[] array = { 111, 13, 6, 7, 8, 3, 4, 9, 15, 28 };
// int i = 0;
// int max = array[0];

// while (i < array.Length)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     i++;
// }
// Console.Write(max);

// int[] array = { 111, 313, 6, 7, 8, 3, 4, 9, 15, 328 };
// int max = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
// }
// Console.Write(max);

int[] array = { 111, 13, 6, 7, 228, 3, 4, 9, 15, 8 };
int max = array[0];

foreach (int element in array)
{
    if (element > max)
    {
        max = element;
    }
}
Console.Write(max);