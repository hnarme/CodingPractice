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
}