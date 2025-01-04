// Задача 1 (из домашнего задания первой лекции).
// Вычислить (с помощью функции) значение формулы 𝑎×𝑏 / 𝑐+𝑑, где a,b,c,d – некоторые целые числа.
// Результат вывести на экран.
// ***************
// РЕШЕНИЕ:
// ***************

double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denominator = c + d;
    double result = numenator / denominator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);