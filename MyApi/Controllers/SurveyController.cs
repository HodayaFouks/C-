using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;

namespace MyApi.Controllers
{
    [RoutePrefix("api/survey")]
    public class SurveyController : ApiController
    {
        [HttpPost]
        [Route("CreateNewSurvey")]
        public IHttpActionResult CreateNewSurvey([FromBody] SurveyDTO survey)
        {
            if(Bl.SurveyBl.CreateNewSurvey(survey)!=null)
               return Ok(Bl.SurveyBl.CreateNewSurvey(survey));
            return Conflict();
        }

        [HttpGet]
        [Route("GetSurveyDetailsById/{surveyId}")]
        public IHttpActionResult GetSurveyDetailsById(int surveyId)
        {
            if(Bl.SurveyBl.GetSurveyDetailsById(surveyId)==null)
                return NotFound();
            return Ok(Bl.SurveyBl.GetSurveyDetailsById(surveyId));    
        }

        public IHttpActionResult UpdateSurveyDetails([FromBody] SurveyDTO survey)
        {
            if (Bl.SurveyBl.UpdateSurveyDetails(survey) == true)
                return Ok();
            return NotFound(); ;
        }

        public IHttpActionResult DeleteSurvey([FromBody] SurveyDTO survey)
        {
            if (Bl.SurveyBl.DeleteSurvey(survey) == true)
                return Ok();
            return Conflict();
        }



    }
}
