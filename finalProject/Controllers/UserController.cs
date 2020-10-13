using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace finalProject.Controllers
{
    [RoutePrefix("api/user")]
    [EnableCors(origins: "*",headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        [Route ("Login")]
        public IHttpActionResult Login([FromBody] UserDTO user)
        {
            UserDTO u=  Bl.UserBl.Login(user);
            if (u != null)
                return Ok();
            return BadRequest();
        }
    }
}
