/*
Задание №0
Реализуйте метод, принимающий в качестве аргумента целочисленный массив.
Если длина массива меньше некоторого заданного минимума,
метод возвращает -1 в качестве кода ошибки, иначе - длину массива.
 */

public class Task_0 {
    public static void main(String[] args) {

        int[] nums = {1, 2, 3, 4, 5, 7};
        int min_length = 5;
        System.out.println(array(nums, min_length));
    }

    public static int array(int[] arr, int min_length) {
        if (arr.length < min_length) {
            return -1;
        }
        return arr.length;
    }
}