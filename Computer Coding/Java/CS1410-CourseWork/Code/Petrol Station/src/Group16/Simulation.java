package Group16;

import Group16.IO.*;
import Group16.Model.PetrolStation;

class Simulation {
	public static void main(String args[]) {
		//initializing variables
		final UserInputInterface input;
		final PetrolStation station;
		final OutputInterface outputInterface;

		//constructing input
		input = new TextUI();
		input.Input(args);

		/*station = new PetrolStation(
				input.getProbabilityP(),
				input.getProbabilityQ(),
				input.getPricePerGallon(),
				input.getNumTicks(),
				input.getNumPumps(),
				input.getSeed(),
				input.getNumTills()
		);*/

		//constructing outputInterface, constructing station
		//forwarding accessor methods from input as parameters for station
		outputInterface = new Output();

       // outputInterface.out(station.getRevenue(), station.getMoneyLost());
	}
}
