import javax.swing.JOptionPane;


public class Exercise5e {

	static int calculation(int m,int x,int b)
	{
		return m * x + b;
	}

	public static void main(String[] args) 
	{
		//declarations
				int m;
				int x;
				int b;
				int t;
				
				//input
				m = Integer.parseInt(JOptionPane.showInputDialog("Enter m"));
				x = Integer.parseInt(JOptionPane.showInputDialog("Enter x"));
				b = Integer.parseInt(JOptionPane.showInputDialog("Enter b"));
				
				//process
				t = calculation (m,x,b);
				
				//output
				System.out.println(t);
	}

}
