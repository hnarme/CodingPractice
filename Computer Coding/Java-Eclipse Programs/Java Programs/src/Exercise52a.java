import javax.swing.JOptionPane;


public class Exercise52a {

	static int calculation (int rate, int hour)
	{
		return rate * hour;
	}
	
	public static void main(String[] args) 
	{
		//declarations
		int pay;
		int rate;
		int hour;
		
		//input
		rate = 10;
		hour = Integer.parseInt(JOptionPane.showInputDialog("Enter staff hours"));
		
		//process
		pay = calculation (rate, hour);
		
		//output
		System.out.println(pay);
	}

}
