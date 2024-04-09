import java.awt.*;
import java.awt.geom.*;
import java.util.Random;

public class FlyMove   
{
    private Canvas myCanvas;

    /**
     * Create a FlyMove object. Creates a fresh canvas and makes it visible.
     */
    public FlyMove()
    {
        myCanvas = new Canvas("Flying Flies", 600, 500);
        myCanvas.setVisible(true);
    }
 
    /**
     * This method demonstrates some of the drawing operations that are
     * available on a Canvas object.
     */
    public void drawDemo()
    {
        myCanvas.setFont(new Font("helvetica", Font.BOLD, 14));
        myCanvas.setForegroundColor(Color.red);

        myCanvas.drawString("We can draw text, ...", 20, 30);
        myCanvas.wait(1000);

        myCanvas.setForegroundColor(Color.black);
        myCanvas.drawString("...draw lines...", 60, 60);
        myCanvas.wait(500);
        myCanvas.setForegroundColor(Color.gray);
        myCanvas.drawLine(200, 20, 300, 50);
        myCanvas.wait(500);
        myCanvas.setForegroundColor(Color.blue);
        myCanvas.drawLine(220, 100, 370, 40);
        myCanvas.wait(500);
        myCanvas.setForegroundColor(Color.green);
        myCanvas.drawLine(290, 10, 320, 120);
        myCanvas.wait(1000);

        myCanvas.setForegroundColor(Color.gray);
        myCanvas.drawString("...and shapes!", 110, 90);

        myCanvas.setForegroundColor(Color.red);

        // the shape to draw and move
        int xPos = 10;
        Rectangle rect = new Rectangle(xPos, 150, 30, 20);

        // move the rectangle across the screen
        for(int i = 0; i < 200; i ++) {
            myCanvas.fill(rect);
            myCanvas.wait(10);
            myCanvas.erase(rect);
            xPos++;
            rect.setLocation(xPos, 150);
        }
        // at the end of the move, draw once more so that it remains visible
        myCanvas.fill(rect);
    }

    /**
     * Simulates two bouncing balls
     */
    public void bounce()
    {
        int ground = 400;   // position of the ground line

        myCanvas.setVisible(true);

        // draw the ground
        myCanvas.drawLine(50, ground, 550, ground);

        // create and show the flies
        Fly fly = new Fly(50, 16, ground, myCanvas);
        fly.draw();
        Fly fly2 = new Fly(70, 20, ground, myCanvas);
        fly2.draw();

        // make them bounce
        boolean finished =  false;
        while(!finished) {
            myCanvas.wait(50);           // small delay
            fly.move();
            fly2.move();
            // stop once ball has travelled a certain distance on x axis
            if(fly.getXPosition() >= 550 && fly2.getXPosition() >= 550)
                finished = true;
        }
        fly.erase();
        fly2.erase();
    }
// 
//     /**
//      * Simulates n bouncing balls
//      * @param numBalls the number of balls to simulate
//      */
//     public void multiBounce(int numBalls)
//     {
//         int ground = 400;   // position of the ground line
//         
//         /*
//          * CHANGE 1
//          * Add the declaration of a local variable called balls 
//          * that will be used to hold a collection of 
//          * BouncingBall objects.
//          * Make your own choice of what to use to hold the balls:
//          * either an array, ArrayList or HashMap, which is best?
//          */
//         BouncingBall[] balls;
//         /* ************ Put your code for 1 above this line **************** */            
//             
//         /*
//          * CHANGE 2
//          * Add a line to initialise the variable called balls.    
//          * Note that the value of the parameter, numBalls, 
//          * tells how many BouncingBall objects there will be.
//          */
//         balls = new BouncingBall[numBalls];
//         /* ************ Put your code for 2 above this line **************** */            
//             
//         myCanvas.setVisible(true);
// 
//         // draw the ground
//         myCanvas.drawLine(50, ground, 550, ground);
// 
//         // create and show the balls
//         
//         /* 
//          * CHANGE 3
//          * write some code below this comment that will construct 
//          * each ball, one at a time, and add them to the collection.
//          * The first ball should be placed at X=50, Y=50.
//          * You will need to figure out how to create the balls at
//          * different X and Y coordinates, otherwise they will
//          * all be drawn on top of each other.
//          * 
//          * Look at the documentation for the constructor in the 
//          * BouncingBall class to find out how to construct a ball.
//          * 
//          * Hints for positioning the balls: 
//          * make the x coordinate increase by 20 for each ball
//          * and the Y coordinate decrease by 30 for each ball
//          * OR put each ball at a random location where the X and Y 
//          * values range between 50 and 150.
//          * 
//          * The following line can be used as a template to construct
//          * each bouncing ball:
//          * new BouncingBall(x, y, 16, Color.blue, ground, myCanvas);
//          */
//         Random r = new Random();
//         for (int i=0; i< numBalls; i++) {
//             int x = r.nextInt(100) + 50;
//             int y = r.nextInt(100)+50;
//             balls[i] = new BouncingBall(x, y, 16, Color.blue, ground, myCanvas);
//         }
//         /* ************ Put your code for 3 above this line **************** */            
//             
//         // make them bounce
//         boolean finished =  false;
//         while(!finished) {
//             myCanvas.wait(50);           // small delay
// 
//             /*
//              * CHANGE 4
//              * Add some code below this comment to 
//              * move each ball in the collection.  Look at the
//              * documentation of the BouncingBall class to see how
//              * to move a ball.
//              */
//             for (int i=0; i<numBalls; i++) {
//                 balls[i].move();
//             }
//             /* ************ Put your code 4 above this line **************** */            
//             
//             // stop once a ball has travelled a certain distance on x axis
//             /*
//              * CHANGE 5 Replace the code below this comment with your
//              * own code that will test the X coordinate of each ball
//              * to check whether all the balls have bounced off the
//              * page.  See the documentation for BouncingBall to find
//              * out how to get the X coordinate of a ball.
//              * 
//              * Your code should do the following: 
//              * if the X position of EVERY the ball in the collection
//              * is greater than or equal to 550, set the variable
//              * called finished to true
//              */
//             finished = true;
//             int i = 0;
//             while (i < numBalls && finished == true) {
//               if (balls[i].getXPosition() < 550) {
//                   finished = false;
//               }
//               i++;
//             }
//             /* ************ Put your code for 5 above this line **************** */
//         }
//         /*
//          * CHANGE 6
//          * Write some code below this comment to erase 
//          * each ball in the collection.
//          * Look at the documentation for BouncingBall 
//          * to find out how to erase the drawing of a ball
//          */
//         for (int i=0; i<numBalls; i++) {
//             balls[i].erase();
//         }
//         /* ************ Put your code for 6 above this line **************** */
//    }
}
