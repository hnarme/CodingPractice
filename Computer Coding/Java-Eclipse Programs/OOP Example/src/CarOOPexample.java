
public class CarOOPexample 
{
	public static class car
	{
		private double enginesize;
		private String colour;
		
		public double getengine()
		{
			return enginesize;
		}
		
		public String getcolour()
		{
			return colour;
		}
		
		public void setengine(double newsize)
		{
			enginesize = newsize;
		}
		
		public void setcolour(String newcolour)
		{
			colour = newcolour;
		}
		
		
		
		
		
		public static void main(String[] args)
		{
			car kevinscar = new car();
			car fredscar = new car();
			
			kevinscar.setengine(2.5);
			fredscar.setengine(3.9);
			
			System.out.println(fredscar.getengine());
		}
	}
}
