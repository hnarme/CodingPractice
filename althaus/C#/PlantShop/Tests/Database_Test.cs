using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlantShop.Models;

[TestClass]
public class Database_Test
{
    [TestMethod]
    public void CheckDatabaseConnection()
    {
        List<Plant> plants = Database.Instance.GetAllPlant();
        if (plants.Count == 0)
        {
            Console.WriteLine("Test Failed!");
            return;
        }

        Console.WriteLine("Test successful!");
    }
}