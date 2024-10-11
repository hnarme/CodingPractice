using System.ComponentModel.Design;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

MySql.Data.MySqlClient.MySqlConnection conn;
string myConnectionString;
const int MAX_CHOICE_NUM = 5;

myConnectionString = "server=127.0.0.1;uid=root;" +
    "pwd=root;database=library";
conn = new MySql.Data.MySqlClient.MySqlConnection();
try
{
    conn.ConnectionString = myConnectionString;
    Console.WriteLine("Connecting to MySQL...");
    conn.Open();

    Menu();

    //MySqlCommand("SELECT * FROM book;");
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

void Menu()
{
    do
    {
        int action = GetUserAction();
        switch (action)
        {
            case 0: CreateBook(); break;
            case 1: DisplayLibrary(); break;
            case 2: UpdateBook(); break;
            case 3: DeleteBook(); break;
            case 4: Exit(); break;

        }

    }
    while (true);

}

int GetUserAction()
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
}

void Exit()
{
    System.Environment.Exit(0);
}