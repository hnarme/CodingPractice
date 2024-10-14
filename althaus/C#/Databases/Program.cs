using System.ComponentModel.Design;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

MySql.Data.MySqlClient.MySqlConnection conn;
string myConnectionString;
const int MAX_CHOICE_NUM = 13;
int userChoice = -1;

myConnectionString = "server=127.0.0.1;uid=root;" +
    "pwd=root;database=library";
conn = new MySql.Data.MySqlClient.MySqlConnection();
try
{
    conn.ConnectionString = myConnectionString;
    Console.WriteLine("Connecting to MySQL...");
    conn.Open();

    MainMenu();
}
catch (MySql.Data.MySqlClient.MySqlException ex)
{
    Console.WriteLine(ex.Message);
}
conn.Close();

void SqlCommand(string sql)
{
    MySqlCommand cmd = new MySqlCommand(sql, conn);
    MySqlDataReader rdr = cmd.ExecuteReader();

    while (rdr.Read())
    {
        Console.WriteLine(rdr[0] + " -- " + rdr[1]);
    }
    rdr.Close();
}

void MainMenu()
{
    do
    {
        Console.WriteLine("Welcome to this library");
        Console.WriteLine("Pick an option:");
        Console.WriteLine("Option 1: Book options");
        Console.WriteLine("Option 2: User options");
        Console.WriteLine("Option 13: Exit");
        MenuSystem();
    }
    while (userChoice < 1 || userChoice > MAX_CHOICE_NUM);
}

void BookMenu()
{
    do
    {
        Console.WriteLine("Pick an option:");
        Console.WriteLine("Option 3: Create a new book");
        Console.WriteLine("Option 4: Display all books");
        Console.WriteLine("Option 5: Rename a books name");
        Console.WriteLine("Option 6: Delete a book");
        //Console.WriteLine("Opption 7: Borrow a book");
        Console.WriteLine("Option 12: Back to the main menu");
        MenuSystem();

    }
    while (userChoice < 1 || userChoice > MAX_CHOICE_NUM);
}

void PeopleMenu()
{
    do
    {
        Console.WriteLine("Pick an option:");
        Console.WriteLine("Option 8: Add a new person to the system");
        Console.WriteLine("Option 9: Display all people on the system");
        Console.WriteLine("Option 10: Rename a persons name");
        Console.WriteLine("Option 11: Remove a person from the system");
        Console.WriteLine("Option 12: Back to the main menu");
        MenuSystem();

    }
    while (userChoice < 1 || userChoice > MAX_CHOICE_NUM);
}

void MenuSystem()
{
    int action = GetUserAction();

    switch (action)
    {
        case 1: BookMenu(); break;
        case 2: PeopleMenu(); break;
        case 3: CreateBook(); break;
        case 4: DisplayLibrary(); break;
        case 5: UpdateBook(); break;
        case 6: DeleteBook(); break;
        //case 7: BorrowBook(); break;
        case 8: CreatePeople(); break;
        case 9: DisplayPeople(); break;
        case 10: UpdatePeople(); break;
        case 11: DeletePeople(); break;
        case 12: MainMenu(); break;
        case 13: Console.WriteLine("Goodbye!"); return;
    }
}

int GetUserAction()
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

void CreateBook()
{
    Console.WriteLine("To add a book to the system please type the book name.");
    string name = Console.ReadLine();
    Console.WriteLine("Now enter the books author.");
    string author = Console.ReadLine();
    SqlCommand($"INSERT INTO book (name, author) VALUES ('{name}', '{author}');");
    Console.WriteLine($"You have successfully added the book {name} written by {author}");
}

void DisplayLibrary()
{
    Console.WriteLine("All books in the library");
    SqlCommand($"SELECT name, author FROM book;");
}

void UpdateBook()
{
    Console.WriteLine("To update a book name please type in the original name of the book.");
    string originalName = Console.ReadLine();
    Console.WriteLine("Now enter the name you want the book to have.");
    string changedName = Console.ReadLine();
    SqlCommand($"UPDATE book SET name = '{changedName}' WHERE name = '{originalName}';");
}

void DeleteBook()
{
    Console.WriteLine("To delete a book please type in the name of the book.");
    string bookName = Console.ReadLine();
    SqlCommand($"DELETE FROM book WHERE name = '{bookName}';");
    Console.WriteLine($"You have successfully deleted the book");
}

void CreatePeople()
{
    Console.WriteLine("To add a person to the system please type the persons first name and surename.");
    string name = Console.ReadLine();
    Console.WriteLine("Now enter the persons date of birth.");
    string dateOfBirth = Console.ReadLine();
    SqlCommand($"INSERT INTO person (name, dateOfBirth) VALUES ('{name}', '{dateOfBirth}');");
    Console.WriteLine($"You have successfully added: {name} with the date of birth: {dateOfBirth} onto the system.");
}

void DisplayPeople()
{
    Console.WriteLine("All people on this library system");
    SqlCommand($"SELECT name, dateOfBirth AS DATE FROM person;");
}

void UpdatePeople()
{
    Console.WriteLine("To update a persons name please type in the first name of the persons name you changed.");
    string originalName = Console.ReadLine();
    Console.WriteLine("Now enter the first name and surname you want the person to have.");
    string changedName = Console.ReadLine();
    SqlCommand($"UPDATE person SET name = '{changedName}' WHERE name = '{originalName}';");
}

void DeletePeople()
{
    Console.WriteLine("To delete a person please type in their first name.");
    string personName = Console.ReadLine();
    SqlCommand($"DELETE FROM person WHERE name = '{personName}';");
    Console.WriteLine($"You have successfully deleted that person.");
}