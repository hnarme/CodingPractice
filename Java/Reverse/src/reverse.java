public class reverse
{
    public static String reverseWord(String str){
        String words[]=str.split("\\s");
        String reverse = "";
        for(String w:words)
        {
            StringBuilder sb=new StringBuilder(w);
            sb.reverse();
            reverse+=sb.toString()+" ";
        }
        return reverse.trim();
    }

    public static void main(String[] args)
    {
        System.out.println(reverseWord("Codecademy is the best!"));
    }
}
