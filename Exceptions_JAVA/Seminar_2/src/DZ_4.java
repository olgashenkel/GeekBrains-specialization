/*
Cимвол `a`

Напишите программу, которая принимает символ a в качестве аргумента и выполняет следующую проверку:
если символ a равен пробелу '', программа должна выбрасывать исключение с сообщением
"Empty string has been input.".
В противном случае программа должна возвращать сообщение
"Your input was - [символ]", где [символ] заменяется на введенный символ a.

На входе:
'0'

На выходе:
Result: Your input was - 0

 */

class Expr4 {
    public static String expr(char a) throws Exception {
// Введите свое решение ниже
        if (a == ' ') {
            throw new IllegalArgumentException("Empty string has been input.");
        } else {
            String str = "Your input was - " + a;
            return str;
        }

    }
}
// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки

public class DZ_4 {
    public static void main(String[] args) {
        char a;

        if (args.length == 0) {
            a = ' '; // Значение по умолчанию, если аргументы не были предоставлены
        } else {
            a = args[0].charAt(0); // Преобразуйте первый аргумент командной строки в символ
        }

        try {
            String result = Expr4.expr(a);
            System.out.println("Result: " + result);
        } catch (Exception e) {
            System.err.println("Error: " + e.getMessage());
        }
    }
}