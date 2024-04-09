
/**
 * Write a description of class WordCollider here.
 * 
 * @author (Hannah Narme) 
 * @version (a version number or a date)
 */
public class WordCollider
{
    // instance variables - replace the example below with your own
    private Text word1;
    private Text word2;
    // the characters contained in word1
    private Text[] charWord1;
    // the characters contained in word2
    private Text[] charWord2;

    /**
     * Constructor for objects of class WordCollider
     */
    public WordCollider(String w1, String w2)
    {
        // initialise instance variables
        word1 = new Text(w1);
        word1.randomizePosition();
        word1.changeColor("green");
        word1.changeSize(48);
        word1.makeVisible();
        word2 = new Text(w2);
        word2.randomizePosition();
        word2.changeColor("orange");
        word2.changeSize(48);
        word2.makeVisible();
        charWord1 = new Text[w1.length()];
        charWord2 = new Text[w2.length()];
        fillChars(charWord1, w1);
        fillChars(charWord2, w2);
    }

    private void fillChars(Text[] a, String w) {
        char[] cs = w.toCharArray();
        for (int i=0; i<a.length; i++) {
            a[i] = new Text(""+cs[i]);
            a[i].changeSize(48);
            a[i].changeColor("red");
        }
    }

    /**
     * Randomize the position of the two words repeatedly and stop
     * when the bounding box of the two words overlaps.
     */
    public void animate()
    {
        word1.makeVisible();
        word2.makeVisible();

        int i = 0;
        while(!checkOverlap())
        {
            word1.randomizePosition();
            word2.randomizePosition();
            i++;
        }
        
        for(Text words1: charWord1)
        {
            words1.makeVisible();
            words1.randomizePosition();
        }
        
        for(Text words2: charWord2)
        {
            words2.makeVisible();
            words2.randomizePosition();
        }
    }

    /**
     * erase the words and any other characters on the display
     */
    public void clearDisplay()
    {
        word1.makeInvisible();
        word2.makeInvisible();
        for(Text words1: charWord1)
        {
            words1.makeInvisible();
        }
        
        for(Text words2: charWord2)
        {
            words2.makeInvisible();
        }
    }

    /**
     * check if the bounding box of the two words overlaps.
     * @return true when the words overlap and false otherwise.
     */
    private Boolean checkOverlap()
    {
        int x0 = word1.getXPosition();
        int x1 = word1.getYPosition();
        int y0 = word2.getXPosition();
        int y1 = word2.getYPosition();

        int x2 = word1.getXPosition() + word1.getTextWidth();
        int y2 = word1.getYPosition() + word1.getTextHeight();
        if((x0 <= y0) && (x2 >= y0) && (x1 <= y1) && (y2 >= y1))
        {
            return true;
        }
        return false;
    }
}