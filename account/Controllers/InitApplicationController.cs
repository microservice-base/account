

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace account.Controllers
{
    [Route("/")]
    [ApiController]
    public class InitApplicationController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Account app is running..." };
        }

    }

}