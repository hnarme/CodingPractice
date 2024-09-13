// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        //Guessing game where you have to guess the number with 3 guesses
        //Add how close the user is to the answer

        Random random = new Random();
        int computerNumber = random.Next(1, 51);
        int guessNum = 3;
        string userChoice;
        Console.WriteLine("Try to guess the number. You win if you get it right and have 3 guesses. Good luck!");

        do
        {
            Console.WriteLine("Type a number between 1-50");
            userChoice = Console.ReadLine();
            if (userChoice == computerNumber.ToString())
            {
                Console.WriteLine("Well done you guessed right!");
                Console.WriteLine("Guesses left: " + guessNum);
                guessNum = 0;
            }
            else if (userChoice != computerNumber.ToString())
            {
                guessNum = guessNum - 1;
                Console.WriteLine("That's incorrect guess again!");
                Console.WriteLine("Guesses left: " + guessNum);
            }

            if (guessNum == 0)
            {
                Console.WriteLine("You have no guesses left. The number was: " + computerNumber + " You Lose!");
            }
        }
        while (guessNum != 0);
    }
}