    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]/[action]")]
    public class StaffApiController : ControllerBase
    {
        [HttpPost]


    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<List<Staff>> GetStaff()
    {
        return Ok(Database.Instance.GetAllStaff());
    }

    [HttpPut]
    []
    public List<Staff> GetStaff()
    {
        return Database.Instance.GetAllStaff();
    }

        [HttpDelete]
    []
    public List<Staff> GetStaff()
    {
        return Database.Instance.GetAllStaff();
    }
    }