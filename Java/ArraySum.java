public class ArraySum {
    public static void main(String[] args) {
        int [ ] myArr = {1, 2, 3, 4};
        //declared a variable sum to store the result and assigned it 0.
        int sum=0;
        //for loop to iterate through the array, and added each element's value to the variable.
        for(int x=0; x<myArr.length; x++) {
            sum += myArr[x];
        }
        System.out.println(sum);
    }
}