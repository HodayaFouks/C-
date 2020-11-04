using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class AnswersDal
    {
        public static bool AddNewAnswer(Answer a)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    db.Answers.Add(a);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static List<Answer> GetAllAnswersByQuestionId(int questionId)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    return db.Answers.Where(x => x.questionId == questionId).ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Update
        public static bool Put(Answer a)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    db.Entry(a).State = EntityState.Modified;
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
        public static bool Delete(Answer a)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    db.Answers.Remove(a);
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
