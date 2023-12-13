import java.util.Scanner;

class EvenNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Input a whole number to check if it is even or odd.");
        int num = scanner.nextInt();
        int calculation = num % 2;
        scanner.close();

        if(calculation == 0)
        {
            System.out.println("Number is even!");
        }
        else
        {
            System.out.println("Number is odd!");
        }
    }
}