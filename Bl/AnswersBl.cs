using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class AnswersBl
    {
        public static bool AddNewAnswer(Dto.AnswersDTO answer)
        {
            return Dal.AnswersDal.AddNewAnswer(Dto.AnswersDTO.ToDal(answer));
        }

        public static List<Dto.AnswersDTO> GetAllAnswersByQuestionId(int questionId)
        {
            return Dto.AnswersDTO.ConvertToListDto(Dal.AnswersDal.GetAllAnswersByQuestionId(questionId));
        }

        public static bool UpdateAnswer(Dto.AnswersDTO answer)
        {
            return Dal.AnswersDal.Put(Dto.AnswersDTO.ToDal(answer));
        }

        public static bool DeleteAnswer(Dto.AnswersDTO answer)
        {
            return Dal.AnswersDal.Delete(Dto.AnswersDTO.ToDal(answer));
        }
    }
}
