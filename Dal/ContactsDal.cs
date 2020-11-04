using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ContactsDal
    {
        public static List<Contact> GetContactsByUserId(int userId)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    return db.Contacts.Where(x => x.userId == userId).ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Update
        public static bool Put(Contact c)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    db.Entry(c).State = EntityState.Modified;
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
        public static bool Delete(Contact c)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    db.Contacts.Remove(c);
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
