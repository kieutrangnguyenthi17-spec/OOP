package org.example;
import java.util.ArrayList;
//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        //use with Interger
        Integer[] intNums = {10, 20, 30, 40};
        Stats<Integer> intStats = new Stats<>(intNums);
        System.out.println("Integer average: " + intStats.average());
        //use with double
        Double[] doubleNums = {1.5, 2.5, 3.5};
        Stats<Double> doubleStats = new Stats<>(doubleNums);
        System.out.println("Double average: " + doubleStats.average());
        //use with string
        String[] stringsNums = {"1.5", "2.5", "3.5"};
        //Stats<String> StringStats = new Stats<>(stringsNums);
        //ArrayList chi chua Integer
        ArrayList<Integer> numbers = new ArrayList<>();

        numbers.add(10);
        numbers.add(20);
        numbers.add(30);

        //lap qua danh sach
        System.out.print("Number: ");
        for (Integer num : numbers) {
            System.out.print(num + " ");
        }
        System.out.println();
        //
        ArrayList<String> names = new ArrayList<>();

        names.add("Alice");
        names.add("Bob");
        names.add("Charlie");
        System.out.print("Names: ");
        for (String name : names) {
            System.out.print(name.toUpperCase() + " ");
        }
        System.out.println();

        //
        ArrayList<Employee> emps = new ArrayList<>();

        emps.add(new Employee("Nam"));
        emps.add(new Employee("Hung"));
        emps.add(new Employee("Thanh"));
        System.out.print("Employees: ");
        for (Employee emp : emps) {
            System.out.print(emp.getName().toUpperCase() + " ");
        }
        System.out.println();
    }
}