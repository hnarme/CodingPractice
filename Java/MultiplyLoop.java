import java.util.Scanner;

public class MultiplyLoop
{
	public static void main(String[] args) {
	    Scanner scanner = new Scanner(System.in);
            int  number = scanner.nextInt();
            int fact = 1;
            while(0 < number)
            {
                fact *= number --;
            }

            System.out.println(fact);
    }
}