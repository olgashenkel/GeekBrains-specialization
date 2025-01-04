// Задача с пятью гирями.
// Дано 5 гирь с разным весом в случайном порядке.
// Найти вес самой тяжелой гири.
// ***************
// РЕШЕНИЕ:
// ***************

int a = 36;
int b = 7;
int c = 28;
int d = 4;
int e = 15;

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}
Console.WriteLine(max);