using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class QuestionsDal
    {
        public static Question AddNewQuestion(Question q)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    db.Questions.Add(q);
                    db.SaveChanges();
                    return q;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<Question> GetAllQuestionsBySurveyId(int surveyId)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    return db.Questions.Where(x => x.surveyId == surveyId).ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Update
        public static bool Put(Question q)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    db.Entry(q).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Delete
        public static bool Delete(Question q)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    db.Questions.Remove(q);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    
    }
}
