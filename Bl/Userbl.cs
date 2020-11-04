using System;
using Dal;
using Dto;

namespace Bl
{
    public class UserBl
    {
        public static Dto.UserDTO Login(string mail, string pass)
        {
            var u1 = Dal.UserDal.Login(mail,pass);
            return new Dto.UserDTO(u1);
        }

        public static Dto.UserDTO SingUp(UserDTO user)
        {
            User u = UserDTO.ToDal(user);
            return new Dto.UserDTO(UserDal.SingUp(u));
        }

        public static Dto.UserDTO GetUserByUserEmail(string ue)
        {
            return new Dto.UserDTO(Dal.UserDal.GetUserByUserEmail(ue));
        }

        public static bool UpdateUser(UserDTO user)
        {
            return Dal.UserDal.Put(Dto.UserDTO.ToDal(user));
        }
    }
}