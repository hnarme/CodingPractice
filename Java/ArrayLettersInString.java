public class ArrayLettersInString {
    public static void main(String[] args) 
    {
        String str  = "readability";
        for(int i = 0; i < str.length(); i++)
        {
            String charToString = str.charAt(i) + "";
            if ("ab".contains(charToString))
            {
                System.out.print(charToString);
            }
        }
    }
}