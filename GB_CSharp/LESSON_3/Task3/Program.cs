// Создадим функцию, которая будет каким-то образом изменять элементы
// массива. Она может изменять все элементы массива, а может и некоторые.
// Создать функцию, которая обнулит чётные элементы массива
// ***************
// РЕШЕНИЕ:
// ***************

void ZeroEventElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = { 1, 5, 4, 7, 8, 9, 10 };
ZeroEventElements(array);
PrintArray(array);