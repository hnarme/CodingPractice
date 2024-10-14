using System.ComponentModel.Design;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

class SqlCommand
{
    public MySql.Data.MySqlClient.MySqlConnection conn;
    public string myConnectionString;
    MainMenu mainMenu = new MainMenu();



    public SqlCommand()
    {
        myConnectionString = "server=127.0.0.1;uid=root;" +
        "pwd=root;database=library";

        conn = new MySql.Data.MySqlClient.MySqlConnection();
    }

    public void Command(string sql)
    {
        try
        {
            conn.ConnectionString = myConnectionString;
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            mainMenu.MenuSystem();

        }
        catch (MySql.Data.MySqlClient.MySqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        conn.Close();



        MySqlCommand cmd = new MySqlCommand(sql, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read())
        {
            Console.WriteLine(rdr[0] + " -- " + rdr[1]);
        }
        rdr.Close();
    }
}