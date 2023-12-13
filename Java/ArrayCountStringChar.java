public class ArrayCountStringChar {
public static void main(String[] args) 
    {
        String input = "ACCTCAGCACTGTCATGCATGTCATGCATGACATGCTCCCCCATAGATGATCAGTCAGTACCA";
        char findA = 'A';
        char findC = 'C';
        char findG = 'G';
        char findT = 'T';
        
        int countA=0;
        int countC=0;
        int countG=0;
        int countT=0;
        
        for(int i=0; i<input.length(); i++)
        {
            if(input.charAt(i) == findA)
            {
                countA++;
            }
            if(input.charAt(i) == findC)
            {
                countC++;
            }
            if(input.charAt(i) == findG)
            {
                countG++;
            }
            if(input.charAt(i) == findT)
            {
                countT++;
            }
            
        }
        System.out.println(findA + ":" +countA + " " + findC + ":" +countC + " " + findG + ":" +countG + " " + findT + ":" +countT);
  }
}