import javax.swing.JOptionPane;


public class Exercise5b {

	static int calculation (int x) 
	
	{
		return x*2;
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
		System.out.println(x);

	}

}
