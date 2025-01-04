/*
Задание №1
 Посмотрите на этот код. Все ли с ним хорошо? Если нет, то скорректируйте его и
обоснуйте свое решение.
 */

import java.util.Arrays;
import java.util.Scanner;

public class Task_1 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] arr = new int[10];
        System.out.println("Укажите индекс элемента массива," +
                "в который хотите записать значение 1");
        int index = 0;

        // дополнить код проверкой на введение числового значения
        if (scanner.hasNextInt()) {
            index = scanner.nextInt();
        } else {
            System.out.println("Укажите индекс элемента массива - целое число!");
        }

        // дополнить код проверкой на введение числового значения в диапазоне массива
        if (index >= arr.length) {
            System.out.println("Укажите индекс элемента в пределах массива!");
        } else {
            arr[index] = 1;
        }


//        try {
//            arr[index] = 1;
//
//        } catch (Exception e) {
//            System.out.println("Указан индекс за пределами массива");
//        }
        System.out.println(Arrays.toString(arr));
    }
}
