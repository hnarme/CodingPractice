import java.util.Scanner;
import java.util.Random;


/*the computer generates a random number, and the user must guess the number. 
The computer will then let the user know that their guess is too high, too low, or correct. 
There is a set number of guesses before the game ends and the number is revealed.*/
public class GuessingGame {

    public static void main(String[] args) 
    {
        int guesslimit = 3;
        int randMax = 100;

        System.out.println("Try and guess what number has been generated. The range is from 0 - " + randMax + ". \nYou also only have " + guesslimit + " guesses. \nGood Luck!");
        Scanner guess1scan = new Scanner(System.in);
        Scanner guess2scan = new Scanner(System.in);
        Scanner guess3scan = new Scanner(System.in);
        int guess1 = guess1scan.nextInt();

        Random rand = new Random();
        int randNum = rand.nextInt(randMax);

        // Correct guess condition
        if (guess1 == randNum) {
            System.out.println("Congratulations! You guessed the number correctly. It is " + randNum + ".");
            System.exit(0);
        }

        // First guess conditions
        if (guesslimit == 3 && guess1 > randNum && guess1 != randNum) {
            guesslimit = 2;
            System.out.println("Your guess of " + guess1 + " is higher than the number.\n" + "You now have " + guesslimit + " guesses left");
        }
        else if (guesslimit == 3 && guess1 < randNum && guess1 != randNum)
        {
            guesslimit = 2;
            System.out.println("Your guess of " + guess1 + " is lower than the number.\n" + "You now have " + guesslimit + " guesses left");
        }

        int guess2 = guess2scan.nextInt();

        if (guess2 == randNum) {
            System.out.println("Congratulations! You guessed the number correctly. It is " + randNum + ".");
            System.exit(0);
        }

        // Second guess conditions
        if (guesslimit == 2 && guess2 > randNum && guess2 != randNum) {
            guesslimit = 1;
            System.out.println("Your guess of " + guess2 + " is higher than the number.\n" + "You now have " + guesslimit + " guesses left");
        }
        else if (guesslimit == 2 && guess2 < randNum && guess2 != randNum)
        {
            guesslimit = 1;
            System.out.println("Your guess of " + guess2 + " is lower than the number.\n" + "You now have " + guesslimit + " guesses left");
        }

        int guess3 = guess3scan.nextInt();

        if (guess3 == randNum) {
            System.out.println("Congratulations! You guessed the number correctly. It is " + randNum + ".");
            System.exit(0);
        }

        // Third guess conditions
        if (guesslimit == 1) {
            System.out.println("Your guess of " + guess3 + " is incorrect.\n");
            System.out.println("You have run out of guesses. The random generated number was: " + randNum + "\n" + "Try again!");
            System.exit(0);

        }
        guess1scan.close();
        guess2scan.close();
        guess3scan.close();

    }
}


