/*
Задание №3
Запишите в файл следующие строки:
Анна=4
Елена=5
Марина=6
Владимир=?
Константин=?
Иван=4
Реализуйте метод, который считывает данные из файла и сохраняет в двумерный массив
(либо HashMap).
В отдельном методе нужно будет пройти по структуре данных.
Если сохранено значение ?, заменить его на соответствующее число.
Если на каком-то месте встречается символ, отличный от числа или ?,
бросить подходящее исключение.
Записать в тот же файл данные с замененными символами ?
 */

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.util.HashMap;
import java.util.Scanner;

public class Task_3 {
    public static void main(String[] args) {

        HashMap<String, Integer> map = readData("Task_3.txt");
        writeData("Task_3.txt", map);
    }

    public static void writeData(String FileName, HashMap<String, Integer> map) {
        try {
            File file = new File(FileName);
            FileWriter writer = new FileWriter(file);

            for (String name : map.keySet()) {
                Integer value = map.get(name);
                writer.write(name + "=" + "\n");
            }
            writer.close();
        } catch (IOException e) {
            System.out.println("Ошибка записи");
        }
    }

    public static HashMap<String, Integer> readData(String FileName) {
        HashMap<String, Integer> map = new HashMap<String, Integer>();
        try {
            File file = new File(FileName);
            Scanner scanner = new Scanner(file);
            while (scanner.hasNextLine()) {
                String line = scanner.nextLine();
                String[] parts = line.split("=");
                if (parts.length != 2) {
                    throw new IllegalArgumentException("Неверные данные в строке" + line);
                }
                String name = parts[0];
                String value = parts[1];
                int valueInt = 0;
                if (value.equals("?")) {
                    valueInt = parts[0].length();
                } else {
                    try {
                        valueInt = Integer.parseInt(value);
                    } catch (NumberFormatException e) {
                        throw new IllegalArgumentException("Неверный формат числа! " + line, e);
                    }
                }
                map.put(name, valueInt);
            }
            scanner.close();

        } catch (FileNotFoundException e) {
            System.out.println("Файл не найден");
        }
        return map;
    }

}
