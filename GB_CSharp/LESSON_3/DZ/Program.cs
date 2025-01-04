// Д/З. Разработка четырех функций по заполнению массива, 
// выводу его на экран, подсчета суммы элементов и их произведения.
// Также вам будет необходимо проверить работоспособность этих функций. 
// ***************
// РЕШЕНИЕ:
// ***************

int n = 10;
int[] arr = new int[n];

void FillArray(int[] arr)
{
    for (int i = 0; i < n; i++)
    {
        arr[i] = i + 1;
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int GetSumOfElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int GetProductOfElements(int[] arr)
{
    int product = 1;
    for (int i = 0; i < n; i++)
    {
        product = product * arr[i];
    }
    return product;
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
FillArray(array);
PrintArray(array);

int sum = GetSumOfElements(array);
Console.WriteLine($"\nСумма чисел массива = {sum}");

int product = GetProductOfElements(array);
Console.WriteLine($"\nПроизведение чисел массива = {product}");