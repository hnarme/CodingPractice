package Group16.Model.Collection;

import Group16.Model.Vehicle;

import java.util.LinkedList;
import java.util.Queue;

/**
 * Created by adnaa on 03/05/2017.
 */
public abstract class Tills {
    protected Queue<Vehicle>[] tills;

    public Tills(int numTills)throws IllegalArgumentException{
        if (numTills<1) new IllegalArgumentException("numTills passed is less than 0, this is not valid");
        tills = new Queue[numTills];

        for (int i=0;i<tills.length;i++){
            Queue<Vehicle> till = new LinkedList<>();
            tills[i]=till;
        }
    }

    abstract public void forAllDoAction();

    public boolean offer(Vehicle e) {
        //find smallest Queue
        Queue<Vehicle> t = tills[0];
        int s = t.size();
        for (int i=1;i<tills.length;i++)
            if (s > tills[i].size()) {
                s = tills[i].size();
                t=tills[i];
            }
        //sent Vehicle to shortest Queue
        return t.offer(e);
    }
}
