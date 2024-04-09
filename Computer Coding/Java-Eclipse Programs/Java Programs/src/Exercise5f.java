import javax.swing.JOptionPane;


public class Exercise5f {

	static int calculation(int y,int c,int d)
	{
		return 2*y + 2*c + 2*d;
	}
	public static void main(String[] args) 
	{
		//declarations
		int y;
		int c;
		int d;
		int x;
		
		//input
		y = Integer.parseInt(JOptionPane.showInputDialog("Enter y"));
		c = Integer.parseInt(JOptionPane.showInputDialog("Enter c"));
		d = Integer.parseInt(JOptionPane.showInputDialog("Enter d"));
		
		//process
		x = calculation (y,c,d);
		
		//output
		System.out.println(x);
	}

}
