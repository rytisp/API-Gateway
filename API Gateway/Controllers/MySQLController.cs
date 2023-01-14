using API_Gateway.Helpers;
using API_Gateway.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_Gateway.Controllers
{
    [AllowAnonymous]
    [Route("api/mysql")]
    [ApiController]
    public class MySQLController : ControllerBase

    {
        [HttpGet("{dataIn}")]
        public string Data(string dataIn)
        {
            var passIn = new MySQLactions();
            passIn.Insert(dataIn);

            return "Inserted and hashed to DB: " + dataIn;
        }
    }
}
