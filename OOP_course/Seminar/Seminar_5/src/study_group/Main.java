package study_group;

import study_group.model.service.Service;
import study_group.view.ConsoleUI;
import study_group.view.View;

public class Main {
    public static void main(String[] args) {


//        Service service = new Service();
//
//        service.addStudent("Паша", 18);
//        service.addStudent("Даша", 18);
//        service.addStudent("Саша", 19);
//        service.addStudent("Маша", 17);
//        System.out.println(service.getStudentListInfo());
//        service.sortByName();
//        System.out.println(service.getStudentListInfo());
//        service.sortByAge();
//        System.out.println(service.getStudentListInfo());

        // 5-ый семинар:
        View view = new ConsoleUI();
        view.start();
    }
}