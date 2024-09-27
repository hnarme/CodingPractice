using System.Security.Cryptography.X509Certificates;

class LibrarianInterface()
{
    MainMenu mainMenu = new MainMenu();
    List<Books> AllBooks = new List<Books>();

    public void modifyData()
    {
        void AddBook(string name, string author, int ISBN, DateOnly LibraryAD)
        {
            Books newbook = new();
            Console.WriteLine("Adding a book");
            Console.WriteLine("Please type in the books Name");
            name = Console.ReadLine();
            name = newbook.Name;
            Console.WriteLine("Please type in the books author");
            author = Console.ReadLine();
            author = newbook.Author;
            Console.WriteLine("Please type in the books ISBN");
            ISBN = int.Parse(Console.ReadLine());
            ISBN = newbook.ISBN;
            LibraryAD = DateOnly.FromDateTime(DateTime.Now);
            LibraryAD = newbook.LibraryAD;

            AllBooks.Add(newbook);

        }
        void RemoveBook()
        {

        }
        void AddCustomer()
        {

        }
        void RemoveCustomer()
        {

        }
        void AddLoan()
        {

        }
        void RemoveLoan()
        {

        }

    }
    public void displayData()
    {
        void DisplayBooks()
        {
            //
            Books book = new();
            book.Name = "The Lord of the Rings";
            book.Author = "J.R.R.Tolkien";
            book.ISBN = 48923847;
            book.LibraryAD = new DateOnly(2024, 1, 15);
            //
            Books book2 = new();
            book.Name = "Skandar and the Unicorn Thief";
            book.Author = "A.F.Steadman";
            book.ISBN = 78942875;
            book.LibraryAD = new DateOnly(2024, 2, 23);
            //
            Books book3 = new();
            book.Name = "Battlefield Earth";
            book.Author = "L. Ron Hubbard";
            book.ISBN = 34859486;
            book.LibraryAD = new DateOnly(2022, 8, 6);
            //
            Books book4 = new();
            book.Name = "The Dinosaur that Pooped Christmas";
            book.Author = "Tom Fletcher";
            book.ISBN = 91239543;
            book.LibraryAD = new DateOnly(2023, 11, 20);

            AllBooks.Add(book);
            AllBooks.Add(book2);
            AllBooks.Add(book3);
            AllBooks.Add(book4);

            foreach (Books bookList in AllBooks)
            {
                Console.WriteLine(bookList.Name, bookList.Author, bookList.ISBN, bookList.LibraryAD);
            }
        }

        void DisplayCustomers()
        {

        }

        void DisplayLoans()
        {

        }
    }
    public bool ExittoMenu()
    {
        mainMenu.DisplayMenu();
        return true;
    }
}