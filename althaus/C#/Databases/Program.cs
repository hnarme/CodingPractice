using MySql.Data.MySqlClient;

MySql.Data.MySqlClient.MySqlConnection conn;
string myConnectionString;

myConnectionString = "server=127.0.0.1;uid=root;" +
    "pwd=root;database=airbnb";
conn = new MySql.Data.MySqlClient.MySqlConnection();
try
{
    conn.ConnectionString = myConnectionString;
    Console.WriteLine("Connecting to MySQL...");
    conn.Open();

    string sql = "SELECT * FROM User";
    MySqlCommand cmd = new MySqlCommand(sql, conn);
    MySqlDataReader rdr = cmd.ExecuteReader();

    while (rdr.Read())
    {
        Console.WriteLine(rdr[0] + " -- " + rdr[1]);
    }
    rdr.Close();
}
catch (MySql.Data.MySqlClient.MySqlException ex)
{
    Console.WriteLine(ex.Message);
}
conn.Close();