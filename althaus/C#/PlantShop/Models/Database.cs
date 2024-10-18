using MySql.Data.MySqlClient;
using PlantShop.Models;

public class Database
{
    private Database() { }

    public static Database Instance { get; } = new Database();

    private string? connectionString;

    public void SetConnectionString(string? connectionString)
    {
        this.connectionString = connectionString;
    }

    private List<Staff> ErrorList(string message)
    {
        Staff staff = new Staff();
        string staffIdString = staff.Staff_Id.ToString();
        staffIdString = message;
        staff.Forename = message;
        staff.Surname = message;
        DateOnly staffDOB = new DateOnly(staff.DateOfBirth.Year, staff.DateOfBirth.Month, staff.DateOfBirth.Day);
        string staffDatOBError = staffDOB.ToString();
        staffDatOBError = message;
        staff.Email = message;
        return new List<Staff>() { staff };
    }

    private MySqlConnection GetOpenConnection()
    {
        if (connectionString == null)
        {
            throw new InvalidOperationException("Connection string not defined");
        }
        MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();
        return conn;
    }

    public List<Staff> GetAllStaff()
    {
        try
        {
            MySqlConnection conn = GetOpenConnection();

            string sql = "SELECT * FROM staff;";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            List<Staff> staffList = new List<Staff>();
            while (reader.Read())
            {
                Staff staff = new Staff();
                string staffID = staff.Staff_Id.ToString();
                staffID = reader[0].ToString();
                staff.Staff_Id = int.Parse(staffID);
                staff.Forename = reader[0].ToString();
                staff.Surname = reader[0].ToString();
                DateOnly staffDOB = new DateOnly(staff.DateOfBirth.Year, staff.DateOfBirth.Month, staff.DateOfBirth.Day);
                string staffDateOB = staffDOB.ToString();
                staffDateOB = reader[0].ToString();
                staff.Email = reader[0].ToString();
                staffList.Add(staff);
            }
            reader.Close();
            conn.Close();
            return staffList;
        }
        catch (Exception exception)
        {
            return ErrorList(exception.Message);
        }
    }



    /*     public void SqlCommand(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " -- " + rdr[1]);
            }
            rdr.Close();
        } */

}