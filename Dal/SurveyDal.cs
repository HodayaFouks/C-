using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class SurveyDal
    {
        public static Survey CreateNewSurvey(Survey s)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    db.Surveys.Add(s);
                    db.SaveChanges();
                    return s;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }


        public static Survey GetSurveyDetailsById(int surveyId)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    return db.Surveys.Where(x => x.id == surveyId).FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        
        //Update
        public static bool Put(Survey s)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                  db.Entry(s).State = EntityState.Modified;
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
        public static bool Delete(Survey s)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    db.Surveys.Remove(s);
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
