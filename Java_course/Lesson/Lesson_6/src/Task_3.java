// Класс LinkedHashSet в Java расширяет класс HashSet, но не добавляет никаких собственных членов.
//
//LinkedHashSet поддерживает связанный список записей в наборе, в том порядке, в котором они были вставлены.
// Это позволяет выполнять итерацию порядка вставки по набору.
//
//То есть, при проходе по LinkedHashSet циклами с использованием итератора элементы будут возвращены
// в том порядке, в котором они были вставлены.
//
//Хэш-код затем используется как индекс, в котором хранятся данные, связанные с ключом.
// Преобразование ключа в его хэш-код выполняется автоматически.
//
//Конструкторы
//Ниже приведен список конструкторов, предоставляемых классом LinkedHashSet.
//HashSet( ) - Этот конструктор создает стандартный HashSet.
//HashSet(Collection c) - Этот конструктор инициализирует хэш-набор, используя элементы коллекции c.
//LinkedHashSet(int capacity) - Этот конструктор инициализирует емкость LinkedHashSet
//                              для заданной целочисленной емкости.
//                              Емкость растет автоматически по мере добавления элементов в HashSet.
//LinkedHashSet(int capacity, float fillRatio) - Этот конструктор инициализирует как емкость,
//                              так и коэффициент заполнения (также называемый нагрузочной способностью)
//                              хэш-набора из его аргументов.

//Методы
//Помимо методов, унаследованных от его родительских классов, HashSet определяет следующие методы:
//
//boolean add(Object o) - Добавляет указанный элемент к этому набору, если он еще не присутствует.
//void clear() - Удаляет все элементы из этого набора.
//Object clone() - Возвращает мелкую копию этого экземпляра HashSet: сами элементы не клонируются.
//boolean contains(Object o) - Возвращает true, если этот набор содержит указанный элемент.
//boolean isEmpty() - Возвращает true, если этот набор не содержит элементов.
//Iterator iterator() - Возвращает итератор по элементам этого набора.
//boolean remove(Object o) - Удаляет указанный элемент из этого набора, если он присутствует.
//int size() - Возвращает количество элементов в этом наборе (его количество элементов).

import java.util.Arrays;
import java.util.LinkedHashSet;

public class Task_3 {
    public static void main(String[] args) {

        var a = new LinkedHashSet<>(Arrays.asList(1,7,2,3,6,4,5));
        var b = new LinkedHashSet<>(Arrays.asList(13,3,17,7,2,11,5));
        a.add(28);
        System.out.println(a); // [1, 7, 2, 3, 6, 4, 5, 28]
        System.out.println(b); // [13, 3, 17, 7, 2, 11, 5]

    }
}
