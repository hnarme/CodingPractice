using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]/[action]")]
public class StaffApiController : ControllerBase
{
    //[HttpPost]


    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<List<Staff>> GetAllStaff()
    {
        return Ok(Database.Instance.GetAllStaff());
    }

    //[HttpPut]
    //[]

    //[HttpDelete]
    //[]
}