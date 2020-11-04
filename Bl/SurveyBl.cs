using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Bl
{
   public class SurveyBl
    {
        public static Dto.SurveyDTO CreateNewSurvey(SurveyDTO survey)
        {
            var s1 = Dal.SurveyDal.CreateNewSurvey(SurveyDTO.ToDal(survey));
            return new Dto.SurveyDTO(s1);
        }

        public static SurveyDTO GetSurveyDetailsById(int surveyId)
        {
            return new Dto.SurveyDTO(Dal.SurveyDal.GetSurveyDetailsById(surveyId));
        }

        public static bool UpdateSurveyDetails(SurveyDTO survey)
        {
            return Dal.SurveyDal.Put(Dto.SurveyDTO.ToDal(survey));
        }

        public static bool DeleteSurvey(SurveyDTO survey)
        {
            return Dal.SurveyDal.Delete(Dto.SurveyDTO.ToDal(survey));
        }
        
    }
}
