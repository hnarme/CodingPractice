
public class Dog {

	public static class dog
	{
		private double hairlength;
		
		public double gethairlength()
		{
			return hairlength;
		}
		
		public void sethairlength(double newsize)
		{
			hairlength = newsize;
		}
		
	public static void main(String[] args) 
	{
		dog bluedog = new dog();
		
		bluedog.sethairlength(4.9);
		
		System.out.println(bluedog.gethairlength());
	}
	
	}
	
}
