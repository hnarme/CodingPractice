using System.Runtime.CompilerServices;
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
        //DateOnly staffDOB = new DateOnly(staff.DateOfBirth.Year, staff.DateOfBirth.Month, staff.DateOfBirth.Day);
        //string staffDatOBError = staffDOB.ToString();
        //staffDatOBError = message;
        staff.Email = message;
        staff.Password = message;
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
        // Comment out try and catch for Database_Test
        //try
        //{
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
        //}
        //catch (Exception exception)
        //{
        //    return ErrorListPlant(exception.Message);
        //}
    }

    public void AddPlant(Plant plant)
    {
        try
        {
            MySqlConnection conn = GetOpenConnection();

            string sql = "INSERT INTO plant (name, family) VALUES (@name, @family);";
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

    public void EditPlant(Plant plant)
    {
        try
        {
            MySqlConnection conn = GetOpenConnection();

            string sql = "UPDATE plant SET name = @name, family = @family WHERE plant_id = @plant_id;";
            Console.WriteLine(sql);
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@name", plant.Name);
            command.Parameters.AddWithValue("@family", plant.Family);
            command.Parameters.AddWithValue("@Plant_Id", plant.Plant_Id);
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

            string sql = "DELETE FROM plant WHERE name = @name AND family = @family;";
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

    public void UpdatePlantName(UpdatePlantName updatePlantName)
    {
        try
        {
            MySqlConnection conn = GetOpenConnection();

            string sql = "UPDATE plant SET name = @newName WHERE name = @oldName";


            Console.WriteLine(sql);
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@oldName", updatePlantName.OldName);
            command.Parameters.AddWithValue("@NewName", updatePlantName.NewName);

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
                //string staffDOB = staff.DateOfBirth.ToString();
                //staffDOB = reader[3].ToString();
                staff.Email = reader[3].ToString();
                staff.Password = reader[4].ToString();
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

            string sql = "INSERT INTO staff (forename, surname, email, password) VALUES (@forename, @surname, @email, @password);";
            Console.WriteLine(sql);
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@forename", staff.Forename);
            command.Parameters.AddWithValue("@surname", staff.Surname);
            //command.Parameters.AddWithValue("@dateOfBirth", staff.DateOfBirth);
            command.Parameters.AddWithValue("@email", staff.Email);
            command.Parameters.AddWithValue("@password", staff.Password);

            command.ExecuteNonQuery();

            conn.Close();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    public void EditStaff(Staff staff)
    {
        try
        {
            MySqlConnection conn = GetOpenConnection();

            string sql = "UPDATE staff SET forename = @forename, surname = @surname, email = @email, password = @password WHERE staff_id = @staff_id;";
            Console.WriteLine(sql);
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@forename", staff.Forename);
            command.Parameters.AddWithValue("@surname", staff.Surname);
            //command.Parameters.AddWithValue("@dateOfBirth", staff.DateOfBirth);
            command.Parameters.AddWithValue("@email", staff.Email);
            command.Parameters.AddWithValue("@password", staff.Password);
            command.Parameters.AddWithValue("@staff_id", staff.Staff_Id);

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

            string sql = "DELETE FROM staff WHERE forename = @forename AND surname = @surname;";
            Console.WriteLine(sql);
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@forename", staff.Forename);
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