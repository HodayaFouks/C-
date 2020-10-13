using System;
using System.Linq;

namespace Dal
{
    public class UserDal
    {
        public static Dal.User Login(User u)
        {
            try
            {
                using (FinalProjectEntities db = new FinalProjectEntities())
                {
                    Dal.User user = db.Users.Where(us => us.email == u.email && us.password == u.password).FirstOrDefault();
                    if (user != null)
                        return user;
                    else
                    {
                        db.Users.Add(u);
                        db.SaveChanges();
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}