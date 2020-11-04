using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class SurveyDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string subject { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public string surveyDirector { get; set; }
        public System.DateTime ? timeStart { get; set; }
        public System.DateTime ? timeEnd { get; set; }
        public Nullable<bool> showResult { get; set; }

        public SurveyDTO()
        {

        }

        public SurveyDTO(Survey s)
        {
            id = s.id;
            name = s.name;
            subject = s.subject;
            createDate = s.createDate;
            surveyDirector = s.surveyDirector;
            timeStart = s.timeStart;
            timeEnd = s.timeEnd;
            showResult = s.showResult;
        }

        public static List<SurveyDTO> ConvertToListDto(List<Dal.Survey> lst)
        {
            return lst.Select(s => new SurveyDTO(s)).ToList();
        }

        public static Survey ToDal(SurveyDTO s)
        {
            return new Dal.Survey
            {
                id = s.id,
                name = s.name,
                subject = s.subject,
                createDate = s.createDate,
                surveyDirector = s.surveyDirector,
                timeStart = s.timeStart,
                timeEnd = s.timeEnd,
                showResult = s.showResult
            };
        }     
    }
}
