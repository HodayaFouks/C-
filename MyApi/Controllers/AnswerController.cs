using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyApi.Controllers
{
    [RoutePrefix("api/answer")]
    public class AnswerController : ApiController
    {
        [HttpPost]
        [Route("AddNewAnswer")]
        public IHttpActionResult AddNewAnswer([FromBody] Dto.AnswersDTO answer)
        {
            if (Bl.AnswersBl.AddNewAnswer(answer))
                return Ok();
            return BadRequest();
        }


        [HttpGet]
        [Route("GetAllAnswersByQuestionId")]
        public IHttpActionResult GetAllAnswersByQuestionId(int questionId)
        {
            if (Bl.AnswersBl.GetAllAnswersByQuestionId(questionId) == null)
                return BadRequest();
            return Ok(Bl.AnswersBl.GetAllAnswersByQuestionId(questionId).ToList());
        }


        [Route("UpdateAnswer")]
        public IHttpActionResult UpdateAnswer([FromBody] Dto.AnswersDTO answer)
        {
            if (Bl.AnswersBl.UpdateAnswer(answer) == true)
                return Ok();
            return NotFound(); ;
        }

        [Route("DeleteAnswer")]
        public IHttpActionResult DeleteAnswer([FromBody] Dto.AnswersDTO answer)
        {
            if (Bl.AnswersBl.DeleteAnswer(answer) == true)
                return Ok();
            return Conflict();
        }
    }
}
