import java.util.HashSet;
import java.util.Scanner;

/**
 * InputReader reads typed text input from the standard text terminal. 
 * The text typed by a user is then returned.
 */
public class InputReader
{
    private Scanner reader;
    
    /**
     * Create a new InputReader that reads text from the text terminal.
     */
    public InputReader()
    {
        reader = new Scanner(System.in);
    }
    
    /**
     * Read a line of text from standard input (the text terminal),
     * and return it as a String.
     *
     * @return  A String containing the 
     *          word(s) typed by the user
     */
    public String getInput() 
    {
        System.out.print("> ");  // print a prompt
        String input = reader.nextLine().trim().toLowerCase();
        return input;
    }
}