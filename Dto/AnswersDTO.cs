using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class AnswersDTO
    {
        public int questionId { get; set; }
        public int answerId { get; set; }
        public string theAnswer { get; set; }
        public int counter { get; set; }
        public bool isRequired { get; set; }

        public AnswersDTO()
        {

        }

        public AnswersDTO(Dal.Answer a )
        {
            questionId = a.questionId;
            answerId = a.answerId;
            theAnswer = a.theAnswer;
            counter = a.counter;
            isRequired = a.isRequired;
        }

        public static List<AnswersDTO> ConvertToListDto(List<Dal.Answer> lst)
        {
            return lst.Select(q => new AnswersDTO(q)).ToList();
        }

        public static Dal.Answer ToDal(AnswersDTO a)
        {
            return new Dal.Answer
            {
                questionId = a.questionId,
                answerId = a.answerId,
                theAnswer = a.theAnswer,
                counter = a.counter,
                isRequired = a.isRequired
            };
        }
    }
}
