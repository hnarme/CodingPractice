import javax.swing.JOptionPane;


public class Exercise52b {

	static int calculation (int rate, int hour)
	{
		return rate * hour;
	}
	
	public static void main(String[] args) 
	
	{
		//declarations
		int pay;
		int rate = 0;
		int hour;
		int age;
				
		//input
		hour = Integer.parseInt(JOptionPane.showInputDialog("Enter staff hours"));
		age = Integer.parseInt(JOptionPane.showInputDialog("Enter your age"));
		
		if (age <= 18)
		{
			rate = 7;
		}
		if (age >= 18)
		{
			rate = 10;
		}
		
		
		//process
		pay = calculation(rate, hour);
		
		if (hour > 37)
		{
			pay = 2 * pay - 37;
		}
		
		//output
		System.out.println(pay);
	}

}
