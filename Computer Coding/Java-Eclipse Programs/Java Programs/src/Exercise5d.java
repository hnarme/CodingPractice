import javax.swing.JOptionPane;


public class Exercise5d {

	static int calculation (int c, int n)
	{
		return 2 * c + 4/n;
	}

	public static void main(String[] args) 
	{
		//declarations
				int c;
				int n;
				int x;
				
				//input
				c = Integer.parseInt(JOptionPane.showInputDialog("Enter c"));
				n = Integer.parseInt(JOptionPane.showInputDialog("Enter n"));
				
				//process
				x = calculation (c,n);
				
				//output
				System.out.println(x);

	}

}
