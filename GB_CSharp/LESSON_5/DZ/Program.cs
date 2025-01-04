/*
Задача 1.
Вычислить факториал натурального числа N.
Добавить в код отладочный вывод, который позволит увидеть "раскручивание" рекурсии, 
т.е. процесс возвратов к местам рекурсивного вызова функции на строке
return n * Fact(n - 1);
*/

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"\nStop requrson: {n}");
        return 1;
    }
     
    Console.Write($"{n} ");

    int fact1 = Fact(n - 1);
    int fact2 = n * fact1;

    Console.WriteLine($"Возврат: n = {n}, fact = {fact1}");
    return fact2;
}

Console.Clear();
Console.WriteLine("Введите число для вычисления факторила:");
int num = int.Parse(Console.ReadLine()!);

Console.Write("\nСтрока чисел для вычисления факториала: ");

Console.WriteLine($"\nРезультат. !{num} = {Fact(num)}");