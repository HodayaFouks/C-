using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;

namespace Dal
{
    public class UserDal
    {
        public static User SingUp(User u)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    //בדיקה אם כבר קיים משתמש בעל כתובת מייל שהוכנסה
                    Dal.User u1 = db.Users.Where(us => us.email == u.email).FirstOrDefault();
                    //אם לא- הוספה למסד נתונים
                    if (u1 == null)
                    {
                        db.Users.Add(u);
                        db.SaveChanges();
                        return u;
                    }
                    return u1;
                }     
            }
            catch(Exception e)
            {
                return null;
            }
        }


        public static User Login(string mail, string pass)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    //בדיקה אם קיים משתמש בעל כתובת מייל שהוכנסה
                    Dal.User user = db.Users.Where(us => us.email == mail).FirstOrDefault();
                    if (user != null)
                        //אם כן- בדיקה אם הסיסמה תואמת
                        if (user.password == pass)
                            return user;
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }


        public static Dal.User GetUserByUserEmail(string ue)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    var user = db.Users.Where(u => u.email == ue).FirstOrDefault();
                    return user;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Update
        public static bool Put(User u)
        {
            try
            {
                using (FinalProjectEntities2 db = new FinalProjectEntities2())
                {
                    db.Entry(u).State = EntityState.Modified;
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
        //GetAll
        //GetByEmail




    }
}