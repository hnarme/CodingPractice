using Microsoft.AspNetCore.Mvc;
using PlantShop.Models;

[ApiController]
[Route("[controller]")]
public class StaffApiController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public ActionResult AddStaff(Staff staff)
    {
        Database.Instance.AddStaff(staff);
        return Created();
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public ActionResult<List<Staff>> GetStaff()
    {
        if (!Request.Headers.ContainsKey("Authorization"))
        {
            return Unauthorized();
        }
        string authHeader = Request.Headers["Authorization"];
        if (!authHeader.StartsWith("Basic "))
        {
            return Unauthorized();
        }
        string usernamePasswordBase64 = authHeader.Substring(6);
        byte[] data = Convert.FromBase64String(usernamePasswordBase64);
        string decodedString = System.Text.Encoding.UTF8.GetString(data);
        string[] usernamePassword = decodedString.Split(':');
        if (usernamePassword.Length != 2)
        {
            return Unauthorized();
        }
        if (usernamePassword[0] == "Bob" && usernamePassword[1] == "password")
        {
            return Ok(Database.Instance.GetAllStaff());
        }
        return Unauthorized();
    }
    [HttpPut]
    public ActionResult UpdateItem(UpdateStaffName updateStaffName)
    {
        Database.Instance.UpdateStaffName(updateStaffName);
        return Ok();
    }
    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult DeleteItem(Staff staff)
    {
        Database.Instance.DeleteStaff(staff);
        return Ok();
    }
}
