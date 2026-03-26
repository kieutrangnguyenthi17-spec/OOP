package org.example;
// generic method
public class Main {
    // Generic method: works with any type T
    public static <T> void printArray(T[] array) {
        for (T item : array) {
            System.out.print(item+" ");
        }
        System.out.println();
    }

    public static void main(String[] args) {
        // Array of Strings
        String[] names = {"Jenny", "Liam"};

        // Array of Integers
        Integer[] numbers = {1, 2, 3};

        // Call the generic method with both arrays
        printArray(names);
        printArray(numbers);
    }
}
