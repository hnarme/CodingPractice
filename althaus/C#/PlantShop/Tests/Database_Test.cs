using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlantShop.Models;

[TestClass]
public class Database_Test
{
    [TestMethod]
    public void CheckDatabaseConnection()
    {
        try{
        Database.Instance.GetAllPlant();

        }
        catch(Exception ex)
        {
            Assert.Fail(ex.Message);
        }
    }

    [TestMethod]
    public void AddGetAndDeletePlantOnDatabase()
    {
        Plant plant = new Plant();
        plant.Name = "TestMethod";
        plant.family = "Test";
        Database.Instance.AddPlant(plant);
        List<Plant> plants = Database.Instance.GetAllPlant();
        bool found = false;
        foreach(Plant plant in plants)
        {
            if(plant.Name == "TestMethod" && plant.Family == "Test")
            {
                found = true;
            }
            if(!found)
            {
                Assert.Fail("Plant not found");
            }
            Database.Instance.DeletePlant(plant);
        }
    }
}