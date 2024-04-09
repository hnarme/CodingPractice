/**
 * The responder class represents a response generator object.
 * It is used to generate an automatic response to the game player,
 * based on specified command that was input.
 * Input is presented to the responder as a word, and based on that
 * word the responder will carry out the command and generate a 
 * String that represents the response.
 *
 * @version    1.0
 * @author     (Hannah Narme)
 */
public class Responder
{
    private int key;
    private Rooms rooms;
    
    public Responder()
    {
        key = 0;
        rooms = new Rooms();
    }

    private String getDescription()
    {
          return rooms.look() + "\n" + getTemperatureDetail();
    }

    private boolean isAlive()
    {
        if(Temperature > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private String lightFire()
    {
        if (totalSticks >= 5)
        {
            resetTemperature();
            totalSticks = 0;
            return "The fire burns all your sticks bright and warms you";
        }
        else 
        {
            totalSticks = 0;
            return "The fire goes out quickly because you need five sticks to make a proper fire";
        }        
    }

    /**
     * Generate a response from the input command.
     * 
     * @param comman  The command entered by the user
     * @return       A string that should be displayed as the response
     */
    public String generateResponse(String command)
    {
        // replace this code with your own implementation written
        // according to the instructions
        decreaseTemperature();
        if(isAlive() == true)

        {        
            if(command .equals ("light"))
            {
                return lightFire() + "\n" +getTemperatureDetail();
            }

            if(command .equals ("move"))
            {
                int value = randDesc.nextInt(Descriptions.size());
                String newvalue = Descriptions.get(value);
                location = new Location(newvalue);
                return "You moved to " + getDescription();
            }
            if((command .equals ("look")))
            {
                return "You are in " + getDescription();
            }
            if((command .equals ("pick")))
            {
                totalSticks = location.takeSticks() + totalSticks;                
                return "You now have " + totalSticks + " sticks" + "\n" + getTemperatureDetail();
            }
            else
            {                
                return "Command not recognized " + getTemperatureDetail();
            }
        }
        return "You are too cold to do anything " + getTemperatureDetail();

    }
}
