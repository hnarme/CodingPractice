
class CustomerInterface
{
  private Database database;
  private int customerId;

  public CustomerInterface(Database libraryDatabase, int libraryCustomerId)
  {
    database = libraryDatabase;
    customerId = libraryCustomerId;
  }

  internal void CustomerMenu()
  {
    int menuChoice;
    do
    {
      Console.WriteLine("Librarian Menu");
      Console.WriteLine("1. Return book");
      Console.WriteLine("2. Search for a book");
      Console.WriteLine("3. Display current loans");
      Console.WriteLine("4. Exit to main menu");

      menuChoice = Utils.GetMenuChoice(4);

      switch (menuChoice)
      {
        case 1: ReturnBook(); break;
        case 2: Utils.SearchForBook(database); break;
        case 3: DisplayCurrentLoans(); break;
      }
    } while (menuChoice != 4);
  }

  private void ReturnBook()
  {
    Console.WriteLine("Return a Book");
    Console.Write("Enter ISBN: ");
    string isbn = Console.ReadLine();
    Book book = database.GetBookByISBN(isbn);
    if (book == null)
    {
      Console.WriteLine("Book not found");
      return;
    }
    Loan loan = database.GetLoanByCustomerIdAndISBN(customerId, isbn);
    if (loan == null)
    {
      Console.WriteLine("Loan not found");
      return;
    }
    if (loan.DueDate < DateOnly.FromDateTime(DateTime.Now))
    {
      Console.WriteLine("Book is overdue, please see the librarian to pay your fine.");
    }
    else
    {
      Console.WriteLine("Book returned, please place the book on the shelf to your right.");
    }
    database.RemoveLoan(customerId, isbn);
  }

  private void DisplayCurrentLoans()
  {
    List<Loan> customerLoans = database.GetLoansByCustomerId(customerId);
    Utils.DisplayLoansToConsole(database, customerLoans);
  }
}