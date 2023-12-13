import java.util.ArrayList;
/**
 * Write a description of class Rooms here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Rooms
{
    private ArrayList<String> room;
    private int key;
    private String roomDesc;
    /**
     * Constructor for objects of class Rooms
     */
    public Rooms()
    {
        room = new ArrayList<String>();
        key = 0;
    }

    private String look()
    {
        String look = roomDesc + "\n" + room + key;
        return look;
    }
    
    private void roomNum()
    {
       room.add("room1");
       room.add("room2");
       room.add("room3");
       room.add("room4");
    }
}
