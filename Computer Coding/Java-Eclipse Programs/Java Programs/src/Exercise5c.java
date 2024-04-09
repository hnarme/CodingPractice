import javax.swing.JOptionPane;


public class Exercise5c {

	static int calculation (int x, int y, int c)
	{
		return x + y + c;
	}

	public static void main(String[] args) 
	{
		//declarations
		{
			int t;
			int x;
			int y;
			int c;
		
		//input
			x = Integer.parseInt(JOptionPane.showInputDialog("Enter x"));
			y = Integer.parseInt(JOptionPane.showInputDialog("Enter y"));
			c = Integer.parseInt(JOptionPane.showInputDialog("Enter c"));
			
		//process
			t = calculation (x,y,c);
			
		//output
			System.out.println(t);
	}

}
}
