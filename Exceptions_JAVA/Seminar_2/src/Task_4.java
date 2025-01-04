/*
Задание №4
Дан следующий код:



Исправьте код, примените
подходящие способы
обработки исключений.
 */

import java.io.*;

public class Task_4 {
    public static void main(String[] args) {
        InputStream inputStream;
        try {
            String[] strings = {"asdf", "asdf"};
            String strings1 = strings[strings.length - 1];
            test();
            int a = 1 / 0;
            inputStream = new FileInputStream("sdafqdsaf");

        } catch (StackOverflowError error) {
            System.out.println("Стек переполнен!");
        } catch (Throwable e) {
            e.printStackTrace();
        } finally {
            System.out.println("Я всё равно выполнился!");
        }
        System.out.println("Я жив!");
    }

    public static void test() throws IOException {
        File file = new File("1");
        file.createNewFile();
        FileReader reader = new FileReader(file);
        reader.read();
        test();
    }
}
