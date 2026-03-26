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
// generic: Generic không phải là một kiểu dữ liệu cụ thể
//mà là cách định nghĩa lớp, interface, method... 
//mà chưa biết chính xác kiểu dữ liệu bên trong.
