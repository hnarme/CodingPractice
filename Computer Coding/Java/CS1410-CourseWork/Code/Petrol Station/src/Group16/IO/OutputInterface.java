package Group16.IO;

/**
*Created by Eden 
*@version 25/04/2017
*@param Out – type double, represents the methods that determine the revenue for the petrol station and the money lost.
*@return 
*@see 

 */
public interface OutputInterface {

    public void out(double revenue, double loss);

    public out(double revenue, double loss, double salesRevenue, double salesLoss);

}
