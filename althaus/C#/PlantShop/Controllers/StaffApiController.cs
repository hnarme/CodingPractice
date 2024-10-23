using Microsoft.AspNetCore.Mvc;
using PlantShop.Models;

[ApiController]
[Route("[controller]/[action]")]
public class StaffApiController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public ActionResult AddStaff(Staff staff)
    {
        return Ok(Database.Instance.AddStaff());
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<List<Staff>> GetStaff()
    {
        return Ok(Database.Instance.GetAllStaff());
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
