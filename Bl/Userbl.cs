using System;
using Dal;
using Dto;

namespace Bl
{
    public class UserBl
    {
        public static UserDTO Login(UserDTO user)
        {
            User u = UserDTO.ToDal(user);
            u=UserDal.Login(u);
            UserDTO u1 = new UserDTO(u);
            return u1;
            
        }
    }
}