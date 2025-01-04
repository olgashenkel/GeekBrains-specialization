/*
Деление

Напишите программу для выполнения арифметической операции деления двух целых чисел a и b.
При этом программа должна проверить, что делитель b не равен нулю, и выполнить деление только в этом случае.
Если b равен нулю, программа должна вернуть результат равный нулю.
После выполнения операции деления, программа также должна вывести сумму чисел a и b с помощью метода printSum.
Если аргументы не переданы через командную строку, используйте значения по умолчанию.

На входе:
'12'
'5'

На выходе:
17
2.4

 */

class Expr3 {

    public static double expr(int a, int b) {
        // Введите свое решение ниже

        if (b != 0) {
            double c = (double) a / b;
            printSum(a, b);
            return c;
        } else {
            printSum(a, b);
            return 0;
        }
    }

    public static void printSum(int a, int b) {
        // Введите свое решение ниже
        int sum = a + b;
        System.out.println(sum);

    }
}

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки

public class DZ_3 {
    public static void main(String[] args) {
        int a;
        int b;

        if (args.length == 0) {
            a = 5;
            b = 0; // Default values if no arguments are provided
        } else {
            a = Integer.parseInt(args[0]);
            b = Integer.parseInt(args[1]);
        }

        double result = Expr3.expr(a, b);
        System.out.println(result);
    }
}