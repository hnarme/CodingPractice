class Utils
{
  private Utils() { }

  public static int GetMenuChoice(int numberOfChoices)
  {
    int userChoice = -1;
    do
    {
      Console.Write("Enter choice: ");
      string userInput = Console.ReadLine();
      try
      {
        userChoice = int.Parse(userInput);
      }
      catch (Exception)
      {
        Console.WriteLine("Invalid input");
      }
    } while (userChoice < 1 || userChoice > numberOfChoices);
    return userChoice;
  }

  public static void SearchForBook(Database database)
  {
    Console.WriteLine("Search for a Book");
    Console.Write("Enter book ISBN, Name or Author: ");
    string userInput = Console.ReadLine();
    List<Book> booksFound = database.FindBooks(userInput);
    Console.WriteLine("Name,Author,ISBN,Library acquisition date");
    foreach (Book book in booksFound)
    {
      Console.WriteLine(book);
    }
  }

  public static void DisplayLoansToConsole(Database database, List<Loan> loans)
  {
    Console.WriteLine("Customer ID,Customer name,Book ISBN,Book name,Due date");
    foreach (Loan loan in loans)
    {
      Customer customer = database.GetCustomerById(loan.Id);
      Book book = database.GetBookByISBN(loan.ISBN);
      if (loan.DueDate < DateOnly.FromDateTime(DateTime.Now))
      {
        Console.ForegroundColor = ConsoleColor.Red;
      }
      Console.WriteLine($"{loan.Id},{customer.Name},{book.ISBN},{book.Name},{loan.DueDate}");
      Console.ForegroundColor = ConsoleColor.White;
    }
  }
}