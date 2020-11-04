using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bl;
using Dto;


namespace MyApi.Controllers
{
    [RoutePrefix("api/user")]
    
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("SingUp")]
        public IHttpActionResult SingUp([FromBody] UserDTO user)
        {
            //מחזיר טרו במקרה שהמשתמש אינו קיים והוכנס לדטבייס
            if(Bl.UserBl.SingUp(user)!=null)
                return Ok(Bl.UserBl.SingUp(user));
            else
                return NotFound();
        }

        [HttpGet]
        [Route("Login/{mail}/{pass}")]
        public IHttpActionResult Login(string mail,string pass)
        {
            var u2 = Bl.UserBl.Login(mail, pass);
        if (u2 !=null)
            return Ok(u2);
        else
            return NotFound();
        }

        
        [HttpGet]
        [Route("GetUserByUserEmail/{UserEmail}")]
        public IHttpActionResult GetUserByUserEmail(string UserEmail)
        {
            return Ok(Bl.UserBl.GetUserByUserEmail(UserEmail));
        }


        [HttpPut]
        [Route("UpdateUser")]
        public IHttpActionResult UpdateUser([FromBody] UserDTO user)
        {
            if (Bl.UserBl.UpdateUser(user) == true)
                return Ok();
            return NotFound();
        }

    }


    }

