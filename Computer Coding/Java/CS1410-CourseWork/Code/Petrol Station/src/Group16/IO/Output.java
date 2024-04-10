package Group16.IO;

/**
*@author eden .
*@version 25/04/2017
*@param revenue – type double, represents the methods that determine the revenue for the petrol station.
*@return loss – type double, represents the money that has been lost at the petrol station.
*@see 

 */
public class Output implements OutputInterface{

    public Output() {
    }

    public void out(double revenue, double loss) {
        System.out.println("Revenue:\t"+revenue+"\t| Loss:\t"+loss);
    }

    public out(double revenue, double loss, double salesRevenue, double salesLoss) {
        this(revenue,loss);
        System.out.println("Sales Revenue:\t"+salesRevenue+"\t| Sales Loss:\t"+salesLoss);
    }

}
