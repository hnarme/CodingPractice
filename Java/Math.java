import java.util.Scanner;

public class Math {
    public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
        System.out.println("Input the two numbers to show the calculations: Add, Subtract, Mutiply and Divide.");
		int numbera = scanner.nextInt();
        int numberb = scanner.nextInt();

        Scanner scannerchoice = new Scanner(System.in);
        System.out.println("Input the corresponding number for the calculation you want to see.");
        System.out.println("1 = Addition");
        System.out.println("2 = Subtraction");
        System.out.println("3 = Mutilication");
        System.out.println("4 = Division");
		int choice = scannerchoice.nextInt();

        Calculations calculation = new Calculations(numbera, numberb);
        
        if(choice == 1)
        {
            System.out.println("Addition: " + calculation.Addition());
        }
        else if(choice == 2)
        {
            System.out.println("Subtraction: " + calculation.Subtraction());
        }
        else if(choice == 3)
        {
            System.out.println("Mutilication: " + calculation.Mutilication());
        }
        else if(choice == 4)
        {
            System.out.println("Division: " + calculation.Division());
        }
        scanner.close();
        scannerchoice.close();
}
}

class Calculations {
    private int numbera;
    private int numberb;
 
    public Calculations(int numbera, int numberb) 
    {
        this.numbera = numbera;
        this.numberb = numberb;  
    }
 
    public int Addition() 
    {
        return numbera + numberb;
    }
 
    public int Subtraction() 
    {
        return numbera - numberb;
    }
 
    public int Mutilication() 
    {
        return numbera * numberb;
    }

    public int Division() 
    {
        return numbera / numberb;
    }
}