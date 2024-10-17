using MySql.Data.MySqlClient;

namespace PlantShop.Models;

public class Staff()
{
    public int Staff_Id { get; set; }
    public string Forename { get; set; }
    public string Surname { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string Email { get; set; }
    public MySql.Data.MySqlClient.MySqlConnection conn;
    public string myConnectionString;


    public void DatabaseConnection()
    {
        myConnectionString = "server=127.0.0.1;uid=root;" +
            "pwd=root;database=plantshop";
        conn = new MySql.Data.MySqlClient.MySqlConnection();
        try
        {
            conn.ConnectionString = myConnectionString;
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            GetStaff();
        }
        catch (MySqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        conn.Close();
    }

    public void SqlCommand(string sql)
    {
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read())
        {
            Console.WriteLine(rdr[0] + " -- " + rdr[1]);
        }
        rdr.Close();
    }

    public List<Staff> GetStaff()
    {
        //SqlCommand($"SELECT * FROM staff;");
        List<Staff> staffList = new List<Staff>();
        Staff dbStaff = new Staff();
        Staff dbStaff2 = new Staff();
        Staff dbStaff3 = new Staff();
        Staff dbStaff4 = new Staff();
        Staff dbStaff5 = new Staff();

        dbStaff.Staff_Id = 0;
        dbStaff.Forename = "John";
        dbStaff.Surname = "Doe";
        dbStaff.DateOfBirth = new DateOnly(1997, 5, 31);
        dbStaff.Email = "johndoe@greenplant.com";

        dbStaff2.Staff_Id = 1;
        dbStaff2.Forename = "John";
        dbStaff2.Surname = "Doe";
        dbStaff2.DateOfBirth = new DateOnly(1997, 5, 31);
        dbStaff2.Email = "johndoe@greenplant.com";

        dbStaff3.Staff_Id = 2;
        dbStaff3.Forename = "John";
        dbStaff3.Surname = "Doe";
        dbStaff3.DateOfBirth = new DateOnly(1997, 5, 31);
        dbStaff3.Email = "johndoe@greenplant.com";

        dbStaff4.Staff_Id = 3;
        dbStaff4.Forename = "John";
        dbStaff4.Surname = "Doe";
        dbStaff4.DateOfBirth = new DateOnly(1997, 5, 31);
        dbStaff4.Email = "johndoe@greenplant.com";

        dbStaff5.Staff_Id = 4;
        dbStaff5.Forename = "John";
        dbStaff5.Surname = "Doe";
        dbStaff5.DateOfBirth = new DateOnly(1997, 5, 31);
        dbStaff5.Email = "johndoe@greenplant.com";

        staffList.Add(dbStaff);
        staffList.Add(dbStaff2);
        staffList.Add(dbStaff3);
        staffList.Add(dbStaff4);
        staffList.Add(dbStaff5);

        return staffList;
    }
}

