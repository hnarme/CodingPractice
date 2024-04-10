package Group23.IO;

import java.util.Random;

/**
 * TextUI
 * abstracts values from <code>String[] args</code> to be returned separately
 * @author Adnaan Hussain
 * @version 31/03/2018 02:21
 */
public class TextUI implements UserInputInterface {

    private double ProbabilityP;
    private double ProbabilityQ;
    private double PricePerGallon;
    private int NumTicks;
    private int NumPumps;
    private int NumTills;
    private int Seed;

    /**
     * Separates information from array type String
     * @param args String[] - input to be divided
     * @throws IllegalArgumentException if the input for ProbabilityP, ProbabilityQ, 
     * PricePerGallon, NumTicks, NumPumps, NumTills, seed is null.
     */
    @Override
    public void Input(String[] args) throws IllegalArgumentException {
        if (args == null)
        {
            throw new IllegalArgumentException("Null details passed to TextUI. Input array should not be empty, "
            		+ "if the input for ProbabilityP, ProbabilityQ, PricePerGallon, NumTicks" +
                    "NumPumps, NumTills or seed are null the program will crash.");
        }

        int i=1;
        if (args.length > i)
            ProbabilityP = Double.parseDouble(args[0]);
        i++;
        if (args.length > i)
            ProbabilityQ = Double.parseDouble(args[1]);
        i++;
        if (args.length > i)
            PricePerGallon = Double.parseDouble(args[2]);
        i++;

        if (args.length > i)
            NumTicks = Integer.parseInt(args[3]);
        i++;
        if (args.length > i)
            NumPumps = Integer.parseInt(args[4]);
        i++;
        if (args.length > i)
            NumTills = Integer.parseInt(args[5]);
        i++;
        if (args.length > i)
            Seed = Integer.parseInt(args[6]);
    }

    /**
     * @return double - value of Probability P
     */
    @Override
    public double getProbabilityP() {
        return ProbabilityP;
    }

    /**
     * @return double - value of Probability Q
     */
    @Override
    public double getProbabilityQ() {
        return ProbabilityQ;
    }

    /**
     * @return double - PRICE_PER_GALLON ratio
     */
    @Override
    public double getPricePerGallon() {
        return PricePerGallon;
    }

    /**
     * @return int - Number of Ticks to run the Simulation for
     */
    @Override
    public int getNumTicks() {
        return NumTicks;
    }

    /**
     * @return int - Number of Pumps to construct
     */
    @Override
    public int getNumPumps() {
        return NumPumps;
    }

    /**
     * @return int - Number of Tills to construct
     */
    @Override
    public int getNumTills() {
        return NumTills;
    }

    /**
     * @return int - Seed for Random generator
     * @see Random ()
     */
    @Override
    public int getSeed() {
        return Seed;
    }
}
