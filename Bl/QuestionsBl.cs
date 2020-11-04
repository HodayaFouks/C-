using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class QuestionsBl
    {
        public static Dto.QuestionsDTO AddNewQuestion(Dto.QuestionsDTO question)
        {
            var q1=Dal.QuestionsDal.AddNewQuestion(Dto.QuestionsDTO.ToDal(question));
            return new Dto.QuestionsDTO(q1);
        }

        public static List<Dto.QuestionsDTO> GetAllQuestionsBySurveyId(int surveyId)
        {
            return Dto.QuestionsDTO.ConvertToListDto(Dal.QuestionsDal.GetAllQuestionsBySurveyId(surveyId));
        }

        public static bool UpdateQuestion(Dto.QuestionsDTO question)
        {
            return Dal.QuestionsDal.Put(Dto.QuestionsDTO.ToDal(question));
        }

        public static bool DeleteQuestion(Dto.QuestionsDTO question)
        {
            return Dal.QuestionsDal.Delete(Dto.QuestionsDTO.ToDal(question));
        }
    }
}
