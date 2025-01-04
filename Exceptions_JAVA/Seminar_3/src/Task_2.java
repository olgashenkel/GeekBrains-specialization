/*
Задание №2
Создайте класс Счетчик, у которого есть метод add(), увеличивающий
значение внутренней int переменной на 1. Сделайте так, чтобы с объектом
такого типа можно было работать в блоке try-with-resources. Подумайте, что
должно происходить при закрытии этого ресурса? Напишите метод для
проверки, закрыт ли ресурс. При попытке вызвать add() у закрытого
ресурса, должен выброситься IOException
 */


public class Task_2 {
    public static void main(String[] args) throws Exception {
        try (Counter counter = new Counter()) {
            System.out.println(counter);
            counter.add();
            System.out.println(counter);
        }
        Counter counter = new Counter();
        System.out.println(counter);
        counter.add();
        System.out.println(counter);
        counter.close();
        counter.add();
    }
}
