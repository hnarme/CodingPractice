Database database = new Database();
database.InitialiseData();
// const string LIBRARIAN_PASSWORD = "Bookw0rm";
const string LIBRARIAN_PASSWORD = "B";

void MainMenu()
{
  int menuChoice;
  do
  {
    Console.WriteLine("Main Menu");
    Console.WriteLine("1. Log in as librarian");
    Console.WriteLine("2. Log in as customer");
    Console.WriteLine("3. Exit");

    menuChoice = Utils.GetMenuChoice(3);
    switch (menuChoice)
    {
      case 1: LibrarianLogIn(); break;
      case 2: CustomerLogIn(); break;
    }
  } while (menuChoice != 3);
}

void LibrarianLogIn()
{
  Console.WriteLine("Librarian Log In");
  Console.Write("Enter librarian password: ");
  string password = Console.ReadLine();
  if (password == LIBRARIAN_PASSWORD)
  {
    LibrarianInterface librarianInterface = new LibrarianInterface(database);
    librarianInterface.LibrarianMenu();
  }
  else
  {
    Console.WriteLine("Invalid librarian password");
  }
}

void CustomerLogIn()
{
  Console.WriteLine("Customer Log In");
  Console.Write("Enter customer ID: ");
  string userCustomerId = Console.ReadLine();
  int customerId;
  try
  {
    customerId = int.Parse(userCustomerId);
  }
  catch (Exception)
  {
    Console.WriteLine("Invalid customer ID");
    return;
  }
  CustomerInterface customerInterface = new CustomerInterface(database, customerId);
  customerInterface.CustomerMenu();
}

MainMenu();