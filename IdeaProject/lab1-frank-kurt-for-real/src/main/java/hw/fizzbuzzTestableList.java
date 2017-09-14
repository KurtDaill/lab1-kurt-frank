package hw;
import java.util.List;

import java.util.*;
import java.util.Scanner;
import java.util.List;

public class fizzbuzzTestableList {

    public void fizzbuzzTestable() {

    }

    public static void main(String[] args) {
        int n;
        Scanner keyboard = new Scanner(System.in);
        n = keyboard.nextInt();
        if (n < 0) {
            n = 0;
        }
        List nStr = fizzBuzz(n);
        //System.out.println(Arrays.toString(StrArr));
    }
    public static List<String> fizzBuzz(int n){
        if(n < 0){
            return null;
        }
        List<String> nList = new ArrayList<String>();

        for(int i = 1; i <= n; i++){
            if(i % 3 == 0){
                if(i % 5 == 0){
                    nList.add("fizzbuzz");
                    continue;
                }else{
                    nList.add("fizz");

                    continue;
                }
            }
            if(i % 5 == 0){
                nList.add("buzz");
                continue;
            }
            nList.add(Integer.toString(i));
        }
        return nList;
    }
}
