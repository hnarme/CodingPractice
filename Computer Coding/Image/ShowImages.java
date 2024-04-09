import javax.swing.ImageIcon;
import java.awt.Image;
import javax.swing.JFrame;
import java.awt.EventQueue;

public class ShowImages extends JFrame
{
    private Image ball;
    private Image apple;
    private Image head;
        
    private void loadImages()
    {
        add(new FrameDemo());
        ImageIcon iid = new ImageIcon("C:/Users/Hannah/Desktop/Game/snake/dot.png");
        ball = iid.getImage();
        ImageIcon iia = new ImageIcon("C:/Users/Hannah/Desktop/Game/snake/apple.png");
        apple = iia.getImage();
        ImageIcon iih = new ImageIcon("C:/Users/Hannah/Desktop/Game/snake/head.png");
        head = iih.getImage();
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    public static void main(String[] args) 
    {
        EventQueue.invokeLater(new Runnable() 
        {
            @Override
            public void run() 
            {                
                JFrame ex = new ShowImages();
                ex.setVisible(true);                
            }
        });
    }
}