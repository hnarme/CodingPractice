//Guessing game where you have to guess the number 

int computerNumber = 5;
int guessNum = 3;
int guessChoice;

do
{
    Console.WriteLine("Try to guess the number. You win if you get it right and have 3 guesses. Good luck!");
    Console.WriteLine("Type a number between 1-50");
    Console.ReadLine();
}
while (guessNum != 0);
