using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;

namespace MyApi.Controllers
{
    [RoutePrefix("api/question")]
    public class QuestionController : ApiController
    {
        [HttpPost]
        [Route("AddNewQuestion")]
        public IHttpActionResult AddNewQuestion([FromBody] QuestionsDTO question)
        {
            if(Bl.QuestionsBl.AddNewQuestion(question)!=null)
               return Ok(Bl.QuestionsBl.AddNewQuestion(question));
            return Conflict();
        }


        [HttpGet]
        [Route("GetAllQuestionsBySurveyId")]
        public IHttpActionResult GetAllQuestionsBySurveyId(int surveyId)
        {
            if (Bl.QuestionsBl.GetAllQuestionsBySurveyId(surveyId)==null)
                return BadRequest();
              return Ok(Bl.QuestionsBl.GetAllQuestionsBySurveyId(surveyId).ToList());
        }

        [Route("UpdateQuestion")]
        public IHttpActionResult UpdateQuestion([FromBody] QuestionsDTO question)
        {
            if (Bl.QuestionsBl.UpdateQuestion(question)==true)
                return Ok();
            return NotFound(); ;
        }

        [Route("DeleteQuestion")]
        public IHttpActionResult DeleteQuestion([FromBody] QuestionsDTO question)
        {
            if (Bl.QuestionsBl.DeleteQuestion(question)==true)
                return Ok();
            return Conflict();
        }

    }
}
