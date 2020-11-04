using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class MailingList_SurveysDTO
    {
        public int mail_survId { get; set; }
        public string email { get; set; }
        public int surveyId { get; set; }
        public Nullable<int> userId { get; set; }
        public bool isAnswered { get; set; }

        public MailingList_SurveysDTO()
        {

        }

        public MailingList_SurveysDTO(MailingList_Surveys ms)
        {
            mail_survId = ms.mail_survId;
            email = ms.email;
            surveyId = ms.surveyId;
            userId = ms.userId;
            isAnswered = ms.isAnswered;
        }

   
        public static MailingList_Surveys ToDal(MailingList_SurveysDTO ms)
        {
            return new Dal.MailingList_Surveys
            {
                mail_survId = ms.mail_survId,
                email = ms.email,
                surveyId = ms.surveyId,
                userId = ms.userId,
                isAnswered = ms.isAnswered
            };
        }
    }
}
