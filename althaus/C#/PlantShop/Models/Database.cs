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

    // Error Lists for Staff and plants tables
    private List<Staff> ErrorListStaff(string message)
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

    private List<Plant> ErrorListPlant(string message)
    {
        Plant plant = new Plant();
        string plantIdString = plant.Plant_Id.ToString();
        plantIdString = message;
        plant.Name = message;
        plant.Family = message;
        return new List<Plant>() { plant };
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

    // Plants SQL Commands
    public List<Plant> GetAllPlant()
    {
        try
        {
            MySqlConnection conn = GetOpenConnection();

            string sql = "SELECT * FROM plant;";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            List<Plant> plantList = new List<Plant>();
            while (reader.Read())
            {
                Plant plant = new Plant();
                string plantID = plant.Plant_Id.ToString();
                plantID = reader[0].ToString();
                plant.Plant_Id = int.Parse(plantID);
                plant.Name = reader[1].ToString();
                plant.Family = reader[2].ToString();
                plantList.Add(plant);
            }
            reader.Close();
            conn.Close();
            return plantList;
        }
        catch (Exception exception)
        {
            return ErrorListPlant(exception.Message);
        }
    }

    public void AddPlant(Plant plant)
    {
        try
        {
            MySqlConnection conn = GetOpenConnection();

            string sql = "INSERT INTO plant (name, family) VALUES ('@name', '@family');";
            Console.WriteLine(sql);
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@name", plant.Name);
            command.Parameters.AddWithValue("@family", plant.Family);

            command.ExecuteNonQuery();

            conn.Close();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    public void DeletePlant(Plant plant)
    {
        try
        {
            MySqlConnection conn = GetOpenConnection();

            string sql = "DELETE FROM plant WHERE name = '@name';";

            Console.WriteLine(sql);
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@name", plant.Name);

            command.ExecuteNonQuery();

            conn.Close();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    // Staff SQL Commands
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
                staff.Forename = reader[1].ToString();
                staff.Surname = reader[2].ToString();
                staff.DateOfBirth = new DateOnly(staff.DateOfBirth.Year, staff.DateOfBirth.Month, staff.DateOfBirth.Day);
                string staffDOB = staff.DateOfBirth.ToString();
                staffDOB = reader[3].ToString();
                staff.Email = reader[4].ToString();
                staffList.Add(staff);
            }
            reader.Close();
            conn.Close();
            return staffList;
        }
        catch (Exception exception)
        {
            return ErrorListStaff(exception.Message);
        }
    }

    public void AddStaff(Staff staff)
    {
        try
        {
            MySqlConnection conn = GetOpenConnection();

            string sql = "INSERT INTO staff (forename, surname, dateOfBirth, email) VALUES ('@forename', '@surname', '@surname', '@email');";
            //string sql = "INSERT INTO staff (forename, surname, dateOfBirth, email) VALUES ('@forename', 'NAME', '1999-05-30', 'H@HOME.COM');";
            Console.WriteLine(sql);
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@forename", staff.Forename);
            command.Parameters.AddWithValue("@surname", staff.Surname);
            command.Parameters.AddWithValue("@dateOfBirth", staff.DateOfBirth);
            command.Parameters.AddWithValue("@email", staff.Email);

            command.ExecuteNonQuery();

            conn.Close();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    public void UpdateStaffName(UpdateStaffName updateStaffName)
    {
        try
        {
            MySqlConnection conn = GetOpenConnection();

            string sql = "UPDATE staff SET forename = @newName WHERE name = @oldName";


            Console.WriteLine(sql);
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@oldName", updateStaffName.OldName);
            command.Parameters.AddWithValue("@NewName", updateStaffName.NewName);

            command.ExecuteNonQuery();

            conn.Close();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    public void DeleteStaff(Staff staff)
    {
        try
        {
            MySqlConnection conn = GetOpenConnection();

            string sql = "DELETE FROM staff WHERE surname = '@surname';";

            Console.WriteLine(sql);
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@surname", staff.Surname);

            command.ExecuteNonQuery();

            conn.Close();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}