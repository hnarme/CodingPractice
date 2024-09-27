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