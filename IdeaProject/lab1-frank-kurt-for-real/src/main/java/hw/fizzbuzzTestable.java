package hw;
import java.awt.*;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class fizzbuzzTestable {

    public void fizzbuzzTestable() {

    }

    public static void main(String[] args) {
        int n;
        Scanner keyboard = new Scanner(System.in);
        n = keyboard.nextInt();
        if (n < 0) {
            n = 0;
        }
        String StrArr[] = fizzBuzz(n);
//        System.out.println(Arrays.toString(StrArr));
    }
    public static String[] fizzBuzz(int n){
        if(n < 0){
            return null;
        }
        String nArr[] = new String[n];
        for(int i = 1; i <= n; i++){
            if(i % 3 == 0){
                if(i % 5 == 0){
                    nArr[i-1] = "fizzbuzz";
                    continue;
                }else{
                    nArr[i-1] = "fizz";

                    continue;
                }
            }
            if(i % 5 == 0){
                nArr[i-1] = "buzz";
                continue;
            }
            nArr[i-1] = Integer.toString(i);
        }
        return nArr;

    }
}
