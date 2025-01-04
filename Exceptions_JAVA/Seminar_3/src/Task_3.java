/*
Задание №3
1. Создайте класс исключения, который будет выбрасываться при делении на
0. Исключение должно отображать понятное для пользователя сообщение об ошибке.
2. Создайте класс исключений, которое будет возникать при обращении к
пустому элементу в массиве ссылочного типа. Исключение должно
отображать понятное для пользователя сообщение об ошибке
3. Создайте класс исключения, которое будет возникать при попытке открыть
несуществующий файл. Исключение должно отображать понятное для
пользователя сообщение об ошибке.
 */


public class Task_3 {

    public class DivisionByZeroException extends Exception {
        public DivisionByZeroException(){
            super("Делить на ноль нельзя!");
        }
    }

    public class NullArrayElementException extends Exception {
        public NullArrayElementException(){
            super("Обращение к пустому элементу массива!");
        }
    }

    public class FileNotFoundException extends Exception {
        public FileNotFoundException(){
            super("Файл не найден!");
        }
    }
}
