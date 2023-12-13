
/**
 * Write a description of class Practice here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Practice
{
    // instance variables - replace the example below with your own
    private int length;

    /**
     * Constructor for objects of class Practice
     */
    public Practice(int length)
    {
        this.length = length;
    }

    public String makeRow(int length)
    {
        String aster = "";
        for (int i = 0; i < length; i++)
        {             
            aster += "*";
        }
        return aster;
    }

    public void triangle(int size)
    {
        int length = size;
        int spaces = 0;
        while (length > 0)
        {
            String row = makeRow(length);
            for(int i = 0; i < (spaces); i++)
            {
                System.out.print(" ");
            }

            System.out.println(row);
            length = length - 2;
            spaces++;
        }
    }
}
