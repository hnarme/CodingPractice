import java.util.Scanner;

//A For loop that prints the output Welcome depending on the number input. Example input 5 should output 5 welcome's.
public class Program
{
    public static void main(String[] args) {
	   Scanner scanner = new Scanner(System.in);
       int n = scanner.nextInt();
       
       for (int i = 0; i < n; i++)
       {
          System.out.println("Welcome"); 
       }
	}
}