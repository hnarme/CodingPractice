package Group16.Model.Collection;

import Group16.Model.hasVolume;

import java.util.LinkedList;
import java.util.Queue;

/** Extension of <code>LinkedList</code> container type with modification of method <code>add</code>,
 *  which adds a limit (type double) which when trying to add an object, if the element size (Osize) + the current capacity,
 *  exceed the limit it won't be added and a boolean representing result of the attempt will be returned.
 * @author Adnaan Hussaion
 * @version 25/04/2017
 * @param <E> - Element type the collection will accept to store.
 * @see LinkedList
 * @see Queue
 */
class LimitedVolumeQueue<E> extends LinkedList implements Queue{
        private double limit;
        private double currentVolume;

    /**
     * Constructor.
     * @param limit - type double. The capacity which after it will reject adding elements when using <code>add</code>.
     */
    public LimitedVolumeQueue(double limit) { this.limit = limit; }

    /**
     * occupy - used to add elements to the LimitedVolumeQueue,
     * will try to add an element to the Queue and return status of the attempt.
     * @param e - type E. Element to be added to Queue.
     * @return type boolean. Represents success of adding element to Queue.
     */
    public boolean add(hasVolume e) {
        if (e == null) throw new NullPointerException("Null Element passed to add - LimitedVolumeQueue");
        double Osize = e.getVolume();
        if ((Osize+currentVolume)>limit)
                return false;
            else {
                currentVolume+=Osize;
            try {
                super.add(e);
            } catch (Exception x) {
                x.printStackTrace();
            }
            return true;
            }
    }

    public boolean offer(hasVolume e){
       return add(e);
    }

    /**
     * remove - used to remove elements to the LimitedCapacityQueue,
     * will try to add an element to the Queue and return status of the attempt.
     */
    @Override
    public Object remove() {
            currentVolume-=((hasVolume) super.peek()).getVolume();
            Object o =super.poll();
        return o;
    }

    /**
     * setLimit
     * @param limit - type double. value to set the limit of the Queue
     */
    public boolean setLimit(double limit) {
        if (limit>=currentVolume){
            this.limit = limit;
            return true;
        }else
            return false;
    }

    /**
     * getLimit
     * @return type double. Current limit of the Queue
     */
    public double getLimit() {
        return limit;
    }

    /**
     * getcurrentVolume
     * @return type double. Current capacity of the Queue
     */
    public double getcurrentVolume() {
        return currentVolume;
    }

    public double volume(){
        double rtn=0.0;
        for (int i=0;i<super.size();i++){
            Object o = super.get(i);
            if (o instanceof hasVolume){
                rtn += ((hasVolume) o).getVolume();
            }
        }
        return rtn;
    }

    @Override
    public String toString() {
        return "LimitedVolumeQueue{" +
                "limit=" + limit +
                ", CurrentVolume=" + currentVolume +
                ", modCount=" + modCount +
                '}';
    }
}
