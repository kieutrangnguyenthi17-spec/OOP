package org.example;

public class Employee {
    private String name;
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    //constructor
    public Employee(String name) {
        this.name = name;
    }
    @Override
    public String toString() {
        return name;
    }
}
