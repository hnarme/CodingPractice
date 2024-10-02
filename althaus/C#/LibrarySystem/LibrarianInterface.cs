class LibrarianInterface
{
  private Database database;

  public LibrarianInterface(Database libraryDatabase)
  {
    database = libraryDatabase;
  }

  internal void LibrarianMenu()
  {
    int menuChoice;
    do
    {
      Console.WriteLine("Librarian Menu");
      Console.WriteLine("1. Add/remove/update data");
      Console.WriteLine("2. Display data");
      Console.WriteLine("3. Exit to main menu");

      menuChoice = Utils.GetMenuChoice(3);

      switch (menuChoice)
      {
        case 1: AddRemoveUpdateData(); break;
        case 2: DisplayData(); break;
      }
    } while (menuChoice != 3);
  }

  private void AddRemoveUpdateData()
  {
    int menuChoice;
    Console.WriteLine("Add/remove Data");
    Console.WriteLine("1. Add book");
    Console.WriteLine("2. Remove book");
    Console.WriteLine("3. Add customer");
    Console.WriteLine("4. Remove customer");
    Console.WriteLine("5. Add loan");
    Console.WriteLine("6. Remove loan");
    Console.WriteLine("7. Renew book");

    menuChoice = Utils.GetMenuChoice(7);

    switch (menuChoice)
    {
      case 1: AddBook(); break;
      case 2: RemoveBook(); break;
      case 3: AddCustomer(); break;
      case 4: RemoveCustomer(); break;
      case 5: AddLoan(); break;
      case 6: RemoveLoan(); break;
      case 7: RenewBook(); break;
    }
  }

  private void AddBook()
  {
    Console.WriteLine("Add Book");
    Console.Write("Enter name: ");
    string bookName = Console.ReadLine();
    Console.Write("Enter author: ");
    string author = Console.ReadLine();
    Console.Write("Enter ISBN: ");
    string isbn = Console.ReadLine();
    if (bookName == "" || isbn == "")
    {
      Console.WriteLine("Book name and ISBN must be entered");
      return;
    }
    database.AddBook(bookName, author, isbn);
  }

  private void RemoveBook()
  {
    Console.WriteLine("Remove Book");
    Console.Write("Enter ISBN: ");
    string isbn = Console.ReadLine();
    if (isbn == "")
    {
      Console.WriteLine("ISBN must be entered");
      return;
    }
    database.RemoveBook(isbn);
  }

  private void AddCustomer()
  {
    Console.WriteLine("Add Customer");
    Console.Write("Enter name: ");
    string customerName = Console.ReadLine();
    Console.Write("Enter date of birth: ");
    string userDateOfBirth = Console.ReadLine();
    DateOnly dateOfBirth;
    try
    {
      dateOfBirth = DateOnly.Parse(userDateOfBirth);
    }
    catch (Exception)
    {
      Console.WriteLine("Invalid date of birth");
      return;
    }
    if (customerName == "")
    {
      Console.WriteLine("Customer name must be entered");
      return;
    }
    database.AddCustomer(customerName, dateOfBirth);
  }

  private void RemoveCustomer()
  {
    Console.WriteLine("Remove Customer");
    Console.Write("Enter ID: ");
    string userInput = Console.ReadLine();
    int customerId;
    try
    {
      customerId = int.Parse(userInput);
    }
    catch (Exception)
    {
      Console.WriteLine("Invalid customer ID");
      return;
    }
    database.RemoveCustomer(customerId);
  }

  private void AddLoan()
  {
    Console.WriteLine("Add Loan");
    Console.Write("Enter Customer ID: ");
    string userCustomerId = Console.ReadLine();
    Console.Write("Enter book ISBN: ");
    string isbn = Console.ReadLine();
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
    if (isbn == "")
    {
      Console.WriteLine("ISBN must be entered");
      return;
    }
    database.AddLoan(customerId, isbn);
  }

  private void RemoveLoan()
  {
    Console.WriteLine("Remove Loan");
    Console.Write("Enter Customer ID: ");
    string userCustomerId = Console.ReadLine();
    Console.Write("Enter book ISBN: ");
    string isbn = Console.ReadLine();
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
    if (isbn == "")
    {
      Console.WriteLine("ISBN must be entered");
      return;
    }
    database.RemoveLoan(customerId, isbn);
  }

  private void RenewBook()
  {
    Console.WriteLine("Remove Loan");
    Console.Write("Enter Customer ID: ");
    string userCustomerId = Console.ReadLine();
    Console.Write("Enter book ISBN: ");
    string isbn = Console.ReadLine();
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
    if (isbn == "")
    {
      Console.WriteLine("ISBN must be entered");
      return;
    }
    database.RenewBook(customerId, isbn);
  }

  private void DisplayData()
  {
    int menuChoice;
    Console.WriteLine("Display Data");
    Console.WriteLine("1. Display all books");
    Console.WriteLine("2. Display all customers");
    Console.WriteLine("3. Display all loans");
    Console.WriteLine("4. Search for a book");
    Console.WriteLine("5. Search for a customer");
    Console.WriteLine("6. Search for all books on loan to a customer");

    menuChoice = Utils.GetMenuChoice(7);

    switch (menuChoice)
    {
      case 1: DisplayBooks(); break;
      case 2: DisplayCustomers(); break;
      case 3: DisplayLoans(); break;
      case 4: Utils.SearchForBook(database); break;
      case 5: SearchForCustomer(); break;
      case 6: SearchForBooksOnLoan(); break;
    }
  }

  private void DisplayBooks()
  {
    Console.WriteLine("Display All Books");
    Console.WriteLine("Name,Author,ISBN,Library acquisition date");
    List<Book> books = database.GetBooks();
    foreach (Book book in books)
    {
      Console.WriteLine(book);
    }
  }

  private void DisplayCustomers()
  {
    Console.WriteLine("Display All Customers");
    Console.WriteLine("Id,Name,Date of Birth");
    List<Customer> customers = database.GetCustomers();
    foreach (Customer customer in customers)
    {
      Console.WriteLine(customer);
    }
  }

  private void DisplayLoans()
  {
    Console.WriteLine("Display All Loans");
    List<Loan> loans = database.GetLoans();
    Utils.DisplayLoansToConsole(database, loans);
  }

  private void SearchForCustomer()
  {
    Console.WriteLine("Search for a Customer");
    Console.Write("Enter customer ID or name: ");
    string userInput = Console.ReadLine();
    List<Customer> customersFound = database.FindCustomers(userInput);
    Console.WriteLine("Id,Name,Date of Birth");
    foreach (Customer customer in customersFound)
    {
      Console.WriteLine(customer);
    }
  }

  private void SearchForBooksOnLoan()
  {
    Console.WriteLine("Search for all Books on loan to a Customer");
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
    List<Loan> loansFound = database.GetLoansByCustomerId(customerId);
    Utils.DisplayLoansToConsole(database, loansFound);
  }
}