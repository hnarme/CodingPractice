import javax.swing.JOptionPane;


public class First {

	static int process (int x, int c)
	{
		return 2*x + c/2;
	}

	public static void main(String[] args) 
	{
		int y ;
		int x ;
		int c ;
		x = Integer.parseInt(JOptionPane.showInputDialog("Enter x"));
		c = Integer.parseInt(JOptionPane.showInputDialog("Enter c"));
		y = process (x,c);
		System.out.println (y);
		
		if (y > 13)
		{
			System.out.println("Chicken");
		}
	}

}
