using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        [Route("getData")]
        public string GEt()
        {
            return "Authenticated with JWT";
        }

        [HttpGet]
        [Authorize]
        [Route("getDetails/{id}")]
        public string Get(int id)
        {
            return "Authenticated with JWT: " + id.ToString();
        }

        [HttpGet]
        [Authorize]
        [Route("getDetails")]
        public string Create()
        {
            return "Authenticated with JWT";
        }
    }
}
