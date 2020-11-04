using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class QuestionsDTO
    {
        public int surveyId { get; set; }
        public int questionId { get; set; }
        public string theQuestion { get; set; }

        public QuestionsDTO()
        {

        }

        public QuestionsDTO(Dal.Question q)
        {
            surveyId = q.surveyId;
            questionId = q.questionId;
            theQuestion = q.theQuestion;
        }

        public static List<QuestionsDTO> ConvertToListDto(List<Dal.Question> lst)
        {
            return lst.Select(q => new QuestionsDTO(q)).ToList();
        }

        public static Dal.Question ToDal(QuestionsDTO q)
        {
            return new Dal.Question
            {
                surveyId = q.surveyId,
                questionId = q.questionId,
                theQuestion = q.theQuestion
            };
        }
    }
}
