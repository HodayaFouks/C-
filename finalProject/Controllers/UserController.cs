﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace finalProject.Controllers
{
    [RoutePrefix("api/users")]
    [EnableCors(origins: "*",headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        public IHttpActionResult Login([FromBody] Dto.UserDTO user)
        {
          Dto.UserDTO u=  Bl.Userbl.Login(user);
        }
    }
}