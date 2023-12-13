import java.util.Scanner;

//your code goes here
class Converter
{
    public static int toBinary(int x)
    {
        String bin = Integer.toBinaryString(x);
        int convert = Integer.parseInt(bin);
        return convert;
    }
}

public class toBinary1 {
    public static void main(String[ ] args) {
        Scanner sc = new Scanner(System.in);
        int x = sc.nextInt();
        System.out.print(Converter.toBinary(x));
    }
}