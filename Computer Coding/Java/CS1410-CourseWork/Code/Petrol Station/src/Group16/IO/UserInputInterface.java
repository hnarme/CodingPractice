package Group16.IO;

/**UserInputInterface
 * Interface which defines use of  UserInput
 * @author Adnaan Hussain
 * @version 31/03/2017 01:58
 */
public interface UserInputInterface {

    /** Separates information from array type String
     * @param args String[] - duplicate of command arguments for Main method
     */
    void Input(String args[]);

    /**
     * @return double - value of Probability P
     */
    double getProbabilityP();

    /**
     * @return double - value of Probability Q
     */
    double getProbabilityQ();

    /**
     * @return double - PRICE_PER_GALLON ratio
     */
    double getPricePerGallon();

    /**
     * @return int - Number of Ticks to run the Simulation for
     */
    int getNumTicks();

    /**
     * @return int - Number of Pumps to construct
     */
    int getNumPumps();

    /**
     * @return int - Number of Tills to construct
     */
    int getNumTills();

    /**
     * @return int - Seed for Random generator
     * @see java.util.Random()
     */
    int getSeed();
}
