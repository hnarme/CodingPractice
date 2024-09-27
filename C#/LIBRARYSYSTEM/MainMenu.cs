class MainMenu()
{
    const int MAX_CHOICE_NUM = 2;
    public bool isMenuDisplayed = false;

    Login login = new Login();


    public void DisplayMenu()
    {
        isMenuDisplayed = true;
        Console.WriteLine("Please select the appropriate login.");
        Console.WriteLine("1. Log in as librarian");
        Console.WriteLine("2. Log in as customer");

        int action = GetUserAction();
        switch (action)
        {
            case 1: login.Librarian(); break;
            case 2: login.Customer(); break;
        }
    }

    private int GetUserAction()
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
}
