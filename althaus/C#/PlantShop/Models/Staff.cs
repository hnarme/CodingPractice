using System.ComponentModel.DataAnnotations;
namespace PlantShop.Models;

public class Staff()
{
    public int Staff_Id { get; set; }

    //[Required]
    //[StringLength(255, MinimumLength = 2)]
    public string Forename { get; set; }

    //[Required]
    //[StringLength(255, MinimumLength = 2)]
    public string Surname { get; set; }

    //Restore when add entry works
    //public DateOnly DateOfBirth { get; set; }

    //[RegularExpression("^[a-zA-Z]+@(?!greenplant.com)$", ErrorMessage = "Make sure the email is according to the company standard format *yourname@greenplant.com*")]
    //[Required]
    //[StringLength(50, MinimumLength = 15)]
    public string Email { get; set; }

    //[Required]
    //[StringLength(50, MinimumLength = 8)]
    public string Password { get; set; }
}