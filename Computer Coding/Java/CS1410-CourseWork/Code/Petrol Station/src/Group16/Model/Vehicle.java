package Group16.Model;

import java.util.Random;

/**
 * Vehicle Object, represents the common properties of Vehicles in the Petrol Station Simulation
 * @author Adnaan Hussain
 * @version 13/04/2017 00:05
 */
public class Vehicle implements hasVolume{

	private Random randomGen;
	private int waitingTime;
	private int tankSize;
	private int fuelToFill;
	private double unitSize;
	private boolean isFull;
	private boolean hasPaid;
	private int timeStamp;
	/**
	 * @param generator - type Random object.
	 * @param unitSize - type double. Is used by any containers with limited capacity to know how much capacity this Vehicle will take up.
	 * @param fuel - type int. Amount of fuel the Vehicle wan't to fill up.
	 */
    public Vehicle(Random generator, int timeStamp, double unitSize, int fuel) {
		//initialising global variables
		this.randomGen = generator;
		this.waitingTime = generator.nextInt(18-12)+12;
		this.timeStamp = timeStamp;
		this.unitSize = unitSize;
		this.tankSize = fuel;
		this.fuelToFill = fuel;
		isFull = false;
		hasPaid = false;
	}

	/**
	 * @param generator - type Random object.
	 * @param unitSize - type double. Is used by any containers with limited capacity to know how much capacity this Vehicle will take up.
	 * @param minFuel - type int. Minimum Value for fuel, Amount of fuel the Vehicle wan't to fill up.
	 * @param maxFuel - type int. Maximum Value for fuel, Amount of fuel the Vehicle wan't to fill up.
	 */
	public Vehicle(Random generator, int timeStamp, double unitSize, int minFuel, int maxFuel) {
		this(generator,timeStamp,unitSize,generator.nextInt(maxFuel-minFuel)+minFuel ); //uses other constructor to finish construction.
	}

	public double getPumpRevenue(double pricePerGallon){
		return pricePerGallon*tankSize;
	}

	/**
	 * @return unit - type double. Amount of space Vehicle takes up.
	 */
	 private double getUnitSize() {
		return unitSize;
	}

	/**
	 *
	 * Filling up - for each action, fill up the gas tank by one gallon per use
	 * Paying - once this action is used once it will pay it's theoretical position being at a Till
	 */

	public boolean fillUp() {
		if (!isFull) {
			//Fill up by one
			if (fuelToFill > 0)
				fuelToFill--;
			else
				isFull = true;
		}
		return isFull;
	}

	public boolean waitingAtTill() {
		if (!hasPaid){
			//Pay
			if (waitingTime ==0)
				hasPaid = true;
			else waitingTime--;
		}
		return hasPaid;
	}



	/**
	 * @return isFull - type boolean. Represents status of the Vehicle filling up
	 */
	boolean getIsFull() {
		return isFull;
	}

	/**
	 * @return hasPaid - type boolean. Represents status of paying.
	 */
	boolean getHasPaid() {
		return hasPaid;
	}

	@Override
	public String toString() {
		return "Vehicle{" +
				"randomGen=" + randomGen +
				", fuelToFill=" + fuelToFill +
				", unitSize=" + unitSize +
				", isFull=" + isFull +
				", hasPaid=" + hasPaid +
				'}';
	}

	@Override
	public double getVolume() {
		return getUnitSize();
	}
}
