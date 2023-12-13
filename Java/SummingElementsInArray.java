import java.util.Scanner;

//calculate the sum of the numbers that are multiples of 4.
public class SummingElementsInArray {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int length = scanner.nextInt();
        int[] array =  new int[length];
        for (int i = 0; i < length; i++) {
            array[i] = scanner.nextInt();
        }
 
        int sum = 0;
        for(int i = 0; i < length; i++)
        {
            if(array[i] % 4 == 0)
            {
                sum += array[i];
            }
        }
        System.out.println(sum);
    }
}
