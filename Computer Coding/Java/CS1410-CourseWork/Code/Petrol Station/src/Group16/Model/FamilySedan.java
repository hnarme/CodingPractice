package Group16.Model;

import java.util.Random;

/**
 * Vehicle Object, represents the common properties of Vehicles in the Petrol Station Simulation
 * @author Adnaan Hussain
 * @version 13/04/2017 01:30
 */
class FamilySedan extends Vehicle{

    /** Creates a Vehicle with predetermined values.
     *  Unit Size: 1.5.
     *  MinFuel: 12.
     *  MaxFuel: 18.
     * @param generator - type Random object.
     */
    public FamilySedan(Random generator, int timeStamp) {
        super(generator, timeStamp, 1.5, 12 ,18);
    }
}
