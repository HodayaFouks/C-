using System;
using Dto;

namespace Bl
{
    public class Userbl
    {
        public static UserDTO Login(UserDTO user)
        {
            Dal.User u = Dto.UserDTO.ToDal(user);
            Dal.User u1=  Dal.Userdal.Login(u);
            Dto.UserDTO u2=new Dto.UserDTO(u1);
            return u2;
        }
    }
}