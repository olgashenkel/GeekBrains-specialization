/*
Задание №0
 Прочитайте название класса исключения, предположите о какой проблеме
свидетельствует. Попробуйте предположить, к какому типу относятся следующие
классы исключений checked, unchecked, error. Проверьте себя с помощью иерархии
классов java:
● ClassCastException --> unchecked - Выполнена неверная операция преобразования типов (ошибка приведения типов)
● StackOverflowError --> error
● IOError --> error
● IOException --> checked
● NullPointerException --> unchecked - Возникает при попытке обращения к полю, методу или объекту по ссылке, равной null. Также исключение выбрасывается, когда метод, не допускающий передачи аргумента null, был вызван с заданием значения null. В последнем случае может быть сгенерировано и исключение типа IllegalArgumentException
● ConcurrentModificationException --> unchecked - Осуществлена попытка изменения объекта конкурирующим потоком вычислений (thread) с нарушением контракта класса (тип определен в пакете jav.util)
● IllegalArgumentException --> unchecked - Методу передано неверное значение аргумента (например, отрицательное, когда метод предполагает задание положительных значений)
● EOFException --> checked
● ClassNotFoundException --> checked - невозможно найти класс
● ThreadDeath </aside> --> error
 */

public class Task_0 {
    public static void main(String[] args) {

        System.out.println("Hello world!");
    }
}