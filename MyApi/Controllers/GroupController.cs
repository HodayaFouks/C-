using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyApi.Controllers
{
    [RoutePrefix("api/Group")]
    public class GroupController : ApiController
    {
        [HttpGet]
        [Route("GetAllGroups")]
        public IHttpActionResult GetAllGroups()
        {
            if (Bl.GroupsBl.GetAllGroups() != null)
                return Ok(Bl.GroupsBl.GetAllGroups());
            return Conflict();
        }

        [HttpPost]
        [Route("CreateNewGroup")]
        public IHttpActionResult CreateNewGroup([FromBody] Dto.GroupsDTO group)
        {
            var g2 = Bl.GroupsBl.CreateNewGroup(group);
            if (g2!= null)
                return Ok(g2);
            return Conflict();
        }

        [HttpPut]
        [Route("UpdateGroup")]
        public IHttpActionResult UpdateGroup([FromBody] Dto.GroupsDTO group)
        {
            if (Bl.GroupsBl.UpdateGroup(group) == true)
                return Ok();
            return NotFound(); ;
        }

        [HttpDelete]
        [Route("DeleteGroup")]
        public IHttpActionResult DeleteGroup([FromBody] Dto.GroupsDTO group)
        {
            if (Bl.GroupsBl.DeleteGroup(group) == true)
                return Ok();
            return Conflict();
        }

    }
}
