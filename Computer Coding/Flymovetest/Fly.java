import java.awt.*;
import java.awt.geom.*;
import javax.swing.*;

public class Fly
{
   private static final int gravity = 3;  // effect of gravity

    private int flyDegradation = 2;
    private Image flyimage;
    private int flyxPosition;
    private int flyyPosition;
    private final int groundPosition;      // y position of ground
    private Canvas canvas;
    private int flyySpeed = 1;                // initial downward speed

    /**
     * Constructor for objects of class BouncingBall
     *
     * @param xPos  the horizontal coordinate of the ball
     * @param yPos  the vertical coordinate of the ball
     * @param ballDiameter  the diameter (in pixels) of the ball
     * @param groundPos  the position of the ground (where the wall will bounce)
     * @param drawingCanvas  the canvas to draw this ball on
     */
    public Fly(int flyxPos, int flyyPos, int groundPos, Canvas drawingCanvas)
    {
        flyxPosition = flyxPos;
        flyyPosition = flyyPos;
        groundPosition = groundPos;
        canvas = drawingCanvas;
        loadImages();
    }

    public void loadImages()
    {
        ImageIcon id = new ImageIcon("J:/images/cartoon-fly.png");
        flyimage = id.getImage();
    }
    
    /**
     * Draw this ball at its current position onto the canvas.
     **/
    public void draw()
    {
        canvas.drawImage(flyimage, flyxPosition, flyyPosition);
    }

    /**
     * Erase the canvas.
     **/
    public void erase()
    {
        canvas.erase();
    }    

    /**
     * Move this ball according to its position and speed and redraw.
     **/
    public void move()
    {
        // remove from canvas at the current position
        erase();
            
        // compute new position
        flyySpeed += gravity;
        flyyPosition += flyySpeed;
        flyxPosition +=2;

        // check if it has hit the ground
        if(flyyPosition >= (groundPosition) && flyySpeed > 0) {
            flyyPosition = (int)(groundPosition);
            flyySpeed = -flyySpeed + flyDegradation; 
        }

        // draw again at new position
        draw();
    }    

    /**
     * return the horizontal position of this ball
     */
    public int getXPosition()
    {
        return flyxPosition;
    }

    /**
     * return the vertical position of this ball
     */
    public int getYPosition()
    {
        return flyyPosition;
    }

}
