import javax.swing.JOptionPane;


public class Exercise5a {

	static int calculation (int x)
	{
		return x;
	}

	public static void main(String[] args) 
	{
		
		//declarations
		int x;
		
		//input
		x = Integer.parseInt(JOptionPane.showInputDialog("Enter x"));
		
		//process
		x = calculation (x);
		
		//output
		if (x == 5)
		{
			System.out.println("it is 5");
		}
		else
		{
			System.out.println("it is not 5");
		}
	}

}
