﻿namespace Catstagram.Server.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class HomeController : ApiController
    {
        [Authorize]
        public ActionResult Get()
        {
            return Ok("Works");
        }
    }
}
