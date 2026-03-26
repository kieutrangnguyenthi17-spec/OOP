package org.example;

public class Stats <T extends Number>
{
    T[] nums;

    //constructor
    Stats(T[] nums){
        this.nums = nums;
    }
    //calculate average
    double average(){
        double sum =0;
        for(T num:nums){
            sum+=num.doubleValue();
        }
        return sum/nums.length;
    }
}
