using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class GroupsDal
    {

        //Add
        public static Group Add(Group g)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    db.Groups.Add(g);
                    db.SaveChanges();
                    return g;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        //GetAllGroups
        public static List<Group> GetAllGroups()
        {

            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    return db.Groups.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        //Update
        public static bool Put(Group g)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    db.Entry(g).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //Delete
        public static bool Delete(Group g)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    db.Groups.Remove(g);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
