/*
package Group16.Model;

import java.util.LinkedList;
import java.util.Queue;
import java.util.Random;

*/
/*
 * Created by Eden on 25/04/2017.
*//*


public class PetrolStation {
    private double revenue;
    private double moneyLost;

    private Random generator;

    public PetrolStation(double probabilityP, double probabilityQ, double pricePerGallon, int numTicks, int numPumps, int seed, int numTills) {
        generator = new Random(seed);
        Queue<Vehicle> till_1 = new LinkedList();
        Queue<Vehicle> till_2 = new LinkedList();
        Queue<Vehicle> till_3 = new LinkedList();
        Queue[] tills = new Queue[]{till_1, till_2, till_3};


        LimitedCapacityQueue<Vehicle> pump_1 = new LimitedCapacityQueue(3);
        LimitedCapacityQueue<Vehicle> pump_2 = new LimitedCapacityQueue(3);
        LimitedCapacityQueue<Vehicle> pump_3 = new LimitedCapacityQueue(3);

        LimitedCapacityQueue[] pumps = new LimitedCapacityQueue[]{pump_1, pump_2, pump_3};

        int secondsPerTick = 10;
        Vehicle vh;

        for (int globalCounter = 0; globalCounter < numTicks; globalCounter++) {
            // Create Vehicle
            vh = null;
            double tempDouble = generator.nextDouble();
            if (   tempDouble < probabilityP ){
                vh = new Motorbike(generator,globalCounter);
            }else if (    tempDouble  < 2*probabilityP ) {
                vh = new SmallCar(generator,globalCounter);
            }else if (    tempDouble  < 2*probabilityP+probabilityQ ) {
                vh = new FamilySedan(generator,globalCounter);
            }

            if (vh!=null) {
                //offer Vehicle to pump
                boolean added = false;
                for (LimitedCapacityQueue p : pumps) {
                    if (!added) {
                        LimitedCapacityQueue pump = p;
                        if (pump.add(vh, vh.getUnitSize())) {
                            added = true;
                        }
                    }
                }
                if (!added){moneyLost-=vh.getPumpRevenue(pricePerGallon);}
            }

            for (LimitedCapacityQueue pump : pumps) {
                vh = (Vehicle) pump.peek();
                if (vh.fillUp()&&!vh.getHasPaid()){
                    //send to Till
                    
                }
            }

            */
/* Set-up

            Pump fill-up
            While Vehicle.isFull is false
            //needs to wait one tick once getting to front of pump before starting to fill
            decrement fuelTillFull
            if fuelTillFull =0, make isFull true
            //on next tick after becoming full, goto next place – stays at front of Pump
            (L1) Shop
            //spends TicksShopping Ticks shopping
            While Vehicle.isDoneShopping
            // same as in fill-up – may use Local class to reduce duplicate functions
            shopRevenue+=Vehicle.getShopExpenditure;
            Pay at Till
            //basically same as Shop – but at the end add to Pumprevenue
            //spends TicksPaying Ticks at the Till
            While Vehicle.isDonePaying
            // same as in fill-up – may use Local class to reduce duplicate functions
            pumpRevenue+=Vehicle.getPumpExpenditure;

            Vehicle leaves
            If Vehicle.isFull & L1.isDoneShopping & .isDonePaying
            Remove from front of Till
            Remove from front of Pump
                    --end of Tick
*//*


        }
    }

    public double getRevenue() {    return revenue; }

    public double getMoneyLost() {  return moneyLost; }
}
*/
