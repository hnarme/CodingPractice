class Database
{
  private List<Book> books = new List<Book>();
  private List<Customer> customers = new List<Customer>();
  private List<Loan> loans = new List<Loan>();

  public void InitialiseData()
  {
    books.Add(new Book("The Lord of the Rings", "J.R.R.Tolkien", "48923847", DateOnly.Parse("15/1/2024")));
    books.Add(new Book("Skandar and the Unicorn Thief", "A.F.Steadman", "78942875", DateOnly.Parse("23/2/2024")));
    books.Add(new Book("Battlefield Earth", "L.Ron Hubbard", "34859486", DateOnly.Parse("6/8/2022")));
    books.Add(new Book("The Dinosaur that Pooped Christmas", "Tom Fletcher", "91239543", DateOnly.Parse("20/11/2023")));
    books.Add(new Book("Conversations with God", "Neale Donald Walsch", "22382593", DateOnly.Parse("25/12/2021")));
    books.Add(new Book("Lifeshocks", "Sophie Sabbage", "19275843", DateOnly.Parse("18/9/2020")));

    customers.Add(new Customer(254, "John Doe", DateOnly.Parse("2/6/1986")));
    customers.Add(new Customer(13, "Geoff Watson", DateOnly.Parse("8/8/2013")));
    customers.Add(new Customer(119, "Kelly Pyke", DateOnly.Parse("25/3/2006")));
    customers.Add(new Customer(87, "Susan Boyle", DateOnly.Parse("2/2/1995")));

    loans.Add(new Loan(254, "34859486", DateOnly.Parse("18/9/2024")));
    loans.Add(new Loan(254, "19275843", DateOnly.Parse("26/9/2024")));
    loans.Add(new Loan(87, "48923847", DateOnly.Parse("2/10/2024")));
  }

  public List<Book> GetBooks()
  {
    return books;
  }

  public List<Customer> GetCustomers()
  {
    return customers;
  }

  public List<Loan> GetLoans()
  {
    return loans;
  }

  internal void AddBook(string bookName, string author, string isbn)
  {
    Book bookAdded = new Book(bookName, author, isbn, DateOnly.FromDateTime(DateTime.Now));
    books.Add(bookAdded);
    Console.WriteLine($"{bookAdded.Name} with ISBN {bookAdded.ISBN} added to the database on {bookAdded.LibraryAcquisitionDate}");
  }

  internal void RemoveBook(string isbn)
  {
    Book book = GetBookByISBN(isbn);
    if (book == null)
    {
      Console.WriteLine($"Book with ISBN {isbn} not found");
      return;
    }
    books.Remove(book);
    Console.WriteLine($"{book.Name} with ISBN {book.ISBN} removed from the database.");
  }

  public Book GetBookByISBN(string isbn)
  {
    foreach (Book book in books)
    {
      if (book.ISBN == isbn)
      {
        return book;
      }
    }
    return null;
  }

  internal void AddCustomer(string customerName, DateOnly dateOfBirth)
  {
    int customerId = GetUniqueCustomerId();
    Customer customerAdded = new Customer(customerId, customerName, dateOfBirth);
    customers.Add(customerAdded);
    Console.WriteLine($"{customerAdded.Name} with Date of Birth {customerAdded.DateOfBirth} added to the database with ID {customerId}");
  }

  private int GetUniqueCustomerId()
  {
    int customerId = 1;

    while (CustomerFound(customerId))
    {
      customerId++;
    }

    return customerId;
  }

  private bool CustomerFound(int customerId)
  {
    foreach (Customer customer in customers)
    {
      if (customer.Id == customerId)
      {
        return true;
      }
    }
    return false;
  }

  internal void RemoveCustomer(int customerId)
  {
    Customer customer = GetCustomerById(customerId);
    if (customer == null)
    {
      Console.WriteLine($"Customer with ID {customerId} not found");
      return;
    }
    customers.Remove(customer);
    Console.WriteLine($"{customer.Name} removed from the database.");
  }

  public Customer GetCustomerById(int customerId)
  {
    foreach (Customer customer in customers)
    {
      if (customer.Id == customerId)
      {
        return customer;
      }
    }
    return null;
  }

  internal void AddLoan(int customerId, string? isbn)
  {
    DateOnly futureDate = DateOnly.FromDateTime(DateTime.Now);
    futureDate = futureDate.AddDays(21);
    Loan loan = new Loan(customerId, isbn, futureDate);
    Customer customer = GetCustomerById(customerId);
    Book book = GetBookByISBN(isbn);
    if (customer == null || book == null)
    {
      Console.WriteLine("Customer/book not found");
      return;
    }
    loans.Add(loan);
    Console.WriteLine($"{customer.Name} has been given book {book.Name}. The due date is {futureDate}.");
  }

  internal void RemoveLoan(int customerId, string? isbn)
  {
    Loan loan = GetLoanByCustomerIdAndISBN(customerId, isbn);
    if (loan == null)
    {
      Console.WriteLine("Loan not found");
      return;
    }
    loans.Remove(loan);
    Console.WriteLine("Loan removed from the database.");
  }

  public List<Loan> GetLoansByCustomerId(int customerId)
  {
    List<Loan> loanList = new List<Loan>();
    foreach (Loan loan in loans)
    {
      if (loan.Id == customerId)
      {
        loanList.Add(loan);
      }
    }
    return loanList;
  }

  public Loan GetLoanByCustomerIdAndISBN(int customerId, string? isbn)
  {
    foreach (Loan loan in loans)
    {
      if (loan.Id == customerId && loan.ISBN == isbn)
      {
        return loan;
      }
    }
    return null;
  }

  internal void RenewBook(int customerId, string? isbn)
  {
    Loan loan = GetLoanByCustomerIdAndISBN(customerId, isbn);
    if (loan == null)
    {
      Console.WriteLine("Loan not found");
      return;
    }
    loan.DueDate = DateOnly.FromDateTime(DateTime.Now.AddDays(21));
    Customer customer = GetCustomerById(customerId);
    Book book = GetBookByISBN(isbn);
    Console.WriteLine($"Loan of {book.Name} to customer {customer.Name} updated. The new due date is {loan.DueDate}.");
  }

  internal List<Book> FindBooks(string userInput)
  {
    List<Book> booksFound = new List<Book>();
    foreach (Book book in books)
    {
      if (book.Name.Contains(userInput) ||
          book.ISBN.Contains(userInput) ||
          book.Author.Contains(userInput))
      {
        booksFound.Add(book);
      }
    }
    return booksFound;
  }

  internal List<Customer> FindCustomers(string userInput)
  {
    List<Customer> customersFound = new List<Customer>();
    foreach (Customer customer in customers)
    {
      if (customer.Name.Contains(userInput) ||
          customer.Id.ToString() == userInput)
      {
        customersFound.Add(customer);
      }
    }
    return customersFound;
  }
}