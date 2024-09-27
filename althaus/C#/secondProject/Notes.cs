void PrintMenu()
{
    Console.WriteLine("Menu option");
    Console.WriteLine("1. Load data");
    Console.WriteLine("2. Display data");
    Console.WriteLine("3. Quit");
    Console.WriteLine("Enter menu option:");
}
string menuOption = "";
while (menuOption != "1" && menuOption != "2" && menuOption != "3")
{
    PrintMenu();
    menuOption = Console.ReadLine();
}

void DisplayGreeting(string title, string surname)
{
    Console.WriteLine("Greetings " + title + " " + surname);
    Console.WriteLine("What can I do for you?");
}
DisplayGreeting("Mr", "Bond"); // Displays "Greetings Mr Bond"
DisplayGreeting("Mrs", "Rowling"); // Displays "Greetings Mrs Rowling"

public class funcexer3
{
    // Define a public static method 'Sum' that takes two integer parameters and returns their sum
    public static int Sum(int num1, int num2)
    {
        int total;
        total = num1 + num2;
        return total;
    }

    // Main method, the entry point of the program
    public static void Main()
    {
        // Print a description of the program
        Console.Write("\n\nFunction to calculate the sum of two numbers :\n");
        Console.Write("--------------------------------------------------\n");

        // Prompt the user to enter a number and read the input as an integer
        Console.Write("Enter a number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter another number and read the input as an integer
        Console.Write("Enter another number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        // Calculate the sum by calling the 'Sum' method and print the result
        Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(n1, n2));
    }
}

public class Addition
{
    public int Sum(int x, int y)
    {
        int result;
        result = x + y;
        return result;
    }

    public static void Main()
    {
        Console.Write("This program will sum two chosen numbers\n");

        Console.Write("Enter the first number");
        int num1 = int.parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.parse(Console.ReadLine());

        Console.WriteLine("\nThe sum of your two chosen numbers is: \n", Sum(num1, num2));
    }
}


void DisplayGreeting(string title, string surname)
{
    Console.WriteLine("Greetings " + title + " " + surname);
    Console.WriteLine("What can I do for you?");
}
DisplayGreeting("Mr", "Bond"); // Displays "Greetings Mr Bond"
DisplayGreeting("Mrs", "Rowling"); // Displays "Greetings Mrs Rowling"


void Menu()
{
    Console.WriteLine("Menu option");
    Console.WriteLine("1 – Enter name and surname");
    Console.WriteLine("2 – Display greeting");
    Console.WriteLine("3 – Quit");

    Console.WriteLine("Enter menu option:");
}

int GetMenuOption()
{
    int menuOption;

    do
    {
        Menu();
        menuOption = int.Parse(Console.ReadLine());

    } while (menuOption < 1 || menuOption > 3);
    return menuOption;
}

void PrintMenu()
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Enter name and surname");
    Console.WriteLine("2. Display greeting");
    Console.WriteLine("3. Quit");
}
int GetMenuChoice()
{
    int menuChoice;
    PrintMenu();
    do
    {
        Console.WriteLine("Enter choice");
        string userInput = Console.ReadLine();
        menuChoice = int.Parse(userInput);
    } while (menuChoice < 1 || menuChoice > 3);
    return menuChoice;
}
string GetUserName()
{
    Console.WriteLine("Enter user name:");
    return Console.ReadLine();
}
void DisplayGreeting(string username)
{
    if (username == "")
    {
        Console.WriteLine("Nice to meet you!");
    }
    else
    {
        Console.WriteLine("Nice to meet you " + username);
    }
}
void Main()
{
    int choice;
    string username = "";
    do
    {
        choice = GetMenuChoice();
        if (choice == 1)
        {
            username = GetUserName();
        }
        if (choice == 2)
        {
            DisplayGreeting(username);
        }
    } while (choice != 3);
}
Main();

// See https://aka.ms/new-console-template for more information
int delay = 3000;
bool key = false;
bool bagOfSand = false;
string firstChoice = "";
string secondChoice = "";

Console.WriteLine("You wake up in a unfamiliar house. There are two items in front of you a key and a bag of sand.");
Thread.Sleep(delay);
Console.WriteLine("You can only choose one (don't ask why) which do you choose?");
firstChoice = Console.ReadLine();
if (firstChoice == "key")
{
    key = true;
    Console.WriteLine("You chose to take the key. you exit the room and see a door to your left and a staircase to your right heading downwards");
    Thread.Sleep(delay);
    Console.WriteLine("Would you like to go left or right?");

    if (secondChoice == "left")
    {
        Console.WriteLine("The door is locked you. The key you have doesn't fit. You then get killed by a goblin.");
        Environment.Exit(0);
    }
    if (secondChoice == "right")
    {
        Console.WriteLine("You go down the stairs and hide from the globin. Then use the key to open the door.");
        Environment.Exit(0);
    }
}
if (firstChoice == "bag of sand")
{
    bagOfSand = true;
    Console.WriteLine("You chose to take the bag of sand. you exit the room and see a door to your left and a staircase to your right heading downwards");
    Thread.Sleep(delay);
    Console.WriteLine("Would you like to go left or right?");

    if (secondChoice == "left")
    {
        Console.WriteLine("The door is locked you then get killed by a goblin.");
        Environment.Exit(0);
    }
    if (secondChoice == "right")
    {
        Console.WriteLine("You go down stairs and throw sand in the goblins face. The door behind the goblin is locked.");
        Thread.Sleep(delay);
        Console.WriteLine("You are eaten by the goblin.");
        Environment.Exit(0);
    }
}

/* // See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

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
} */

using System.Data;

int delay = 2000;
bool key = false;
bool bagOfSand = false;
bool death = false;
bool win = false;
string location = "";
string itemChoice = "";
string movement;

Console.WriteLine("You wake up in a unfamiliar house. There are two items in front of you a key and a bag of sand.");
Thread.Sleep(delay);
Console.WriteLine("You can only choose one (don't ask why) which do you choose?");
itemChoice = Console.ReadLine();

if (itemChoice == "key")
{
    key = true;
    Console.WriteLine("You chose to take the key.");
}
if (itemChoice == "bag of sand")
{
    bagOfSand = true;
    Console.WriteLine("You chose to take the bag of sand.");
}

Console.WriteLine("You exit the room.");
Hallway();

do
{
    Console.WriteLine("Which direction do you want to take?");
    movement = Console.ReadLine();
    Directions();
}
while (death || win);

void Directions()
{
    if (movement.ToLower() == "left" && location == "Hallway")
    {
        Room();
    }
    else if (movement.ToLower() == "right" && location == "Hallway")
    {
        Door();
    }

    if (movement.ToLower() == "right" && location == "Room")
    {
        Hallway();
    }
}

void Hallway()
{
    location = "Hallway";
    Console.WriteLine("You are in a hallway.");
    Console.WriteLine("You see a door to your LEFT and a staircase to your RIGHT heading downwards.");
}

void Room()
{
    location = "Room";
    Console.WriteLine("You are in a well decorated room.");
    Console.WriteLine("You see only one item that looks useful. It's a");
}

void Door()
{
    location = "Door";

    if (movement == "left" && key == true)
    {
        Console.WriteLine("You go down the stairs and hide from the globin. Then use the key to open the door.");
        Thread.Sleep(delay);
        Console.WriteLine("Well Done! You escaped!");
        win = true;
    }
    else if (movement == "left" && bagOfSand == true)
    {
        Console.WriteLine("You go down stairs and throw sand in the goblins face. The door behind the goblin is locked.");
        Console.WriteLine("The goblin is getting back up");
        Console.WriteLine("You can stand and fight(attack) or run back upstairs(up)");
    }
    if (movement == "attack")
    {
        Console.WriteLine("You're not strong enough to fight with your bare hands. You are eaten by the goblin.");
        death = true;
    }
    if (movement == "up")
    {
        Console.WriteLine("You run upstairs before the goblin gets up.");
        Hallway();
    }
}




