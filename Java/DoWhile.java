import java.util.Scanner;
public class DoWhile
{
    public static void main(String[] args) 
    {
	   Scanner read = new Scanner(System.in);
       int password = 0;
       do
       {
           System.out.println("Write password");
           password = read.nextInt();
       }
       
        while (password != 8819);
    }
}