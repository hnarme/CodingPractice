class Login
{
    private const int MAX_LIBRARIAN_CHOICE_NUM = 3;
    private const int MAX_CUSTOMER_CHOICE_NUM = 4;

    private bool LibrarianLogin;

    private string password = "Bookw0rm";

    MainMenu mainMenu = new MainMenu();

    LibrarianInterface libInterface = new LibrarianInterface();
    CustomerInterface cusInterface = new CustomerInterface();



    public void Librarian()
    {
        do
        {
            Console.WriteLine("Enter librarian password: ");
            Console.WriteLine("<Enter password>");
            password = Console.ReadLine();

        } while (password != password);


        do
        {
            Console.WriteLine("librarian Menu");

            Console.WriteLine("1. Add/remove/update data");
            Console.WriteLine("2. Display data");
            Console.WriteLine("3. Exit to Main Menu");



            int action = GetLibUserAction();
            switch (action)
            {
                case 1: libInterface.modifyData(); break;
                case 2: libInterface.displayData(); break;
                case 3: libInterface.ExittoMenu(); break;
            }
        } while (libInterface.ExittoMenu());
    }

    int GetLibUserAction()
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
        } while (userChoice < 1 || userChoice > MAX_LIBRARIAN_CHOICE_NUM);
        return userChoice;
    }

    public void Customer()
    {
        Console.WriteLine("Customer login interface");
    }

    int GetCusUserAction()
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
        } while (userChoice < 1 || userChoice > MAX_CUSTOMER_CHOICE_NUM);
        return userChoice;
    }
}