namespace PlantShop.Models;

public class Staff()
{
    public int Staff_Id { get; set; }
    public string Forename { get; set; }
    public string Surname { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}