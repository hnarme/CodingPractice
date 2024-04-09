
public class Challenge {

	public static class shape
	{
		private int height;
		private int width;
	
		public int getheight()
		{
			return height;
		}
		
		public int getwidth()
		{
			return width;
		}
		
		public void setheight(int newheight)
		{
			height = newheight;
		}
		
		public void setwidth(int newwidth)
		{
			width = newwidth;
		}
		
	
	public class triangle extends shape
	{
		
	}
	
	public class square extends shape
	{
		
	}
	
	public static void main(String[] args) 
	{
		triangle mytriangle = new triangle();
		square mysquare = new square();
		triangle mysecondtriangle = new triangle();
		int area;
		
		mytriangle.setheight(5);
		mytriangle.setwidth(7);
		
		area = (mytriangle.getheight() * mytriangle.getwidth()) / 2;
		
		System.out.println("the area of my rtiangle is" + area);
	}
	}
}

