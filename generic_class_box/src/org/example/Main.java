package org.example;

public class Main {
    public static void main(String[] args) {
        //use with Integer
        Integer[] intNums={10,20,30,40};
        Stats<Integer> intStats = new Stats<>(intNums);
        System.out.println("Integer average: " + intStats.average());
        //use with Double
        Double[] doubleNums={1.5, 2.5, 3.5};
        Stats<Double> doubleStats = new Stats<>(doubleNums);
        System.out.println("Double average: " + doubleStats.average());
        //use with String
        // String[] stringsNums = {"1.5", "2.5", "3.5"};
        // Stats<String> stringStats = new Stats<>(stringsNums);
    }
}