using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyApi.Controllers
{
    [RoutePrefix("api/contact")]
    public class ContactController : ApiController
    {
        //[HttpPost]
        //[Route("createNewContact")]
        //public IHttpActionResult CreateNewContact([FromBody] Dto.ContactsDTO contact)
        //{
        //    if (Bl.SurveyBl.CreateNewSurvey(contact))
        //        return Ok();
        //    return BadRequest();
        //}

        [HttpGet]
        [Route("getContactsByUserId")]
        public IHttpActionResult GetContactsByUserId(int userId)
        {
            if (Bl.ContactsBl.GetContactsByUserId(userId) == null)
                return BadRequest();
            return Ok(Bl.ContactsBl.GetContactsByUserId(userId).ToList());
        }

        [Route("UpdateContact")]
        public IHttpActionResult UpdateContact([FromBody] Dto.ContactsDTO contact)
        {
            if (Bl.ContactsBl.UpdateContact(contact) == true)
                return Ok();
            return NotFound(); ;
        }

        [Route("Deletecontact")]
        public IHttpActionResult Deletecontact([FromBody] Dto.ContactsDTO contact)
        {
            if (Bl.ContactsBl.DeleteContact(contact) == true)
                return Ok();
            return Conflict();
        }
    }
}
