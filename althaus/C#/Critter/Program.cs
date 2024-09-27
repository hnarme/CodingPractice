const int MAX_CHOICE_NUM = 3;
Critter crit = new Critter();

Console.WriteLine("Try to keep your critter alive for 5 days to win!");
Console.WriteLine("First name your new Critter!");
string name = Console.ReadLine();
do
{
    Console.WriteLine("Day Count: " + crit.getDayCount());
    PrintMenu();
    int action = GetUserAction();
    switch (action)
    {
        //case 0: joe.NameCritter(name); break;
        case 1: crit.Feed(); break;
        case 2: crit.Sleep(); break;
        case 3: crit.Play(); break;

    }
} while (crit.IsAlive() && crit.getDayCount() < 5);
// Methods defined below
void PrintMenu()
{
    Console.WriteLine("What would you like to do with " + crit.NameCritter(name) + "?");
    Console.WriteLine("1. Feed");
    Console.WriteLine("2. Sleep");
    Console.WriteLine("3. Play");
}
int GetUserAction()
{
    int userChoice = -1;
    do
    {
        Console.WriteLine("Enter a number:");
        try
        {
            string userInput = Console.ReadLine();
            userChoice = int.Parse(userInput);
        }
        catch
        {
            Console.WriteLine("Invalid number");
        }
    } while (userChoice < 1 || userChoice > MAX_CHOICE_NUM);
    return userChoice;
}