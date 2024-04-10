package Group16.Model;

import java.util.Random;

/**
 * Vehicle Object, represents the common properties of Vehicles in the Petrol Station Simulation
 * @author Adnaan Hussain
 * @version 13/04/2017 01:20
 */
class SmallCar extends Vehicle{

    /** Creates a Vehicle with predetermined values.
     *  Unit Size: 1.0.
     *  MinFuel: 7.
     *  MaxFuel: 9.
     * @param generator - type Random object.
     */
    public SmallCar(Random generator,int timeStamp) {
        super(generator, timeStamp, 1.0, 7 ,9);
    }

}
