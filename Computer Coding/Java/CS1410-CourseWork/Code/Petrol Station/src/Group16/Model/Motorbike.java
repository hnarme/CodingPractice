package Group16.Model;

import java.util.Random;

/**
 * Vehicle Object, represents the common properties of Vehicles in the Petrol Station Simulation
 * @author Adnaan Hussain
 * @version 13/04/2017 01:30
 */
class Motorbike extends Vehicle{

    /** Creates a Vehicle with predetermined values.
     *  Unit Size: 0.75.
     *  Fuel 5.
     * @param generator - type Random object.
     */
    public Motorbike(Random generator, int timeStamp) {
        super(generator, timeStamp, 0.75, 5);
    }
}
