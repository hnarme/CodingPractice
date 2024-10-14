class MainMenu
{
    SqlCommand sqlCommand = new SqlCommand();
    const int MAX_CHOICE_NUM = 5;
    int userChoice = -1;

    public void Menu()
    {
        do
        {
            Console.WriteLine("Welcome to this library");
            Console.WriteLine("Pick an option:");
            Console.WriteLine("Option 1: Create a new book");
            Console.WriteLine("Option 2: Display all books");
            Console.WriteLine("Option 3: Rename a books name");
            Console.WriteLine("Option 4: Delete a book");
            Console.WriteLine("Option 5: Exit");


            //MenuSystem();
        }
        while (userChoice < 1 || userChoice > MAX_CHOICE_NUM);

    }

    public int GetUserAction()
    {

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

    public void MenuSystem()
    {
        switch (GetUserAction())
        {
            case 1: CreateBook(); break;
            case 2: DisplayLibrary(); break;
            case 3: UpdateBook(); break;
            case 4: DeleteBook(); break;
            case 5: Console.WriteLine("Goodbye!"); return;
        }
    }

    void CreateBook()
    {
        Console.WriteLine("To add a book to the system please type the book name.");
        string name = Console.ReadLine();
        Console.WriteLine("Now enter the books author.");
        string author = Console.ReadLine();
        sqlCommand.Command($"INSERT INTO book (name, author) VALUES ('{name}', '{author}');");
        Console.WriteLine($"You have successfully added the book {name} written by {author}");
    }

    void DisplayLibrary()
    {
        Console.WriteLine("All books in the library");
        sqlCommand.Command($"SELECT name, author FROM book;");
    }

    void UpdateBook()
    {
        Console.WriteLine("To update a book name please type in the original name of the book.");
        string originalName = Console.ReadLine();
        Console.WriteLine("Now enter the name you want the book to have.");
        string changedName = Console.ReadLine();
        sqlCommand.Command($"UPDATE book SET name = '{changedName}' WHERE name = '{originalName}';");
    }

    void DeleteBook()
    {
        Console.WriteLine("To delete a book please type in the name of the book.");
        string bookName = Console.ReadLine();
        sqlCommand.Command($"DELETE FROM book WHERE name = '{bookName}';");
        Console.WriteLine($"You have successfully deleted the book");
    }
}