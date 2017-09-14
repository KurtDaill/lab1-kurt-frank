import java.util.Scanner;

public class fizzbuzz{
        public static void main(String[] args){
        int n;
        Scanner keyboard = new Scanner(System.in);
        
        while(true){
        System.out.println("Please enter a positive integer, to set length.");
        n = keyboard.nextInt();
        if(n < 0){
            System.out.println("Positive integers only.");
            }else break;        
        }
        
        for(int i = 1; i <= n; i++){
            if(i % 3 == 0){
                if(i % 5 == 0){
                    System.out.println("fizzbuzz");
                    continue;
                }else{
                    System.out.println("fizz");
                    continue;
                }
            }
            if(i % 5 == 0){
                System.out.println("buzz");
                continue;
            }
            System.out.println(i);
        }
    }
}