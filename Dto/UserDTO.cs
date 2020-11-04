using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
 public class UserDTO
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public UserDTO()
        {

        }

        public UserDTO(User u)
        {
            userId = u.userId;
            userName = u.userName;
            password = u.password;
            email = u.email;
        }


        public static List<UserDTO> ConvertToListDto(List<Dal.User> lst)
        {
            return lst.Select(u => new UserDTO(u)).ToList();
        }

        public static User ToDal(UserDTO u)
        {
            return new Dal.User
            {
                email = u.email,
                userName = u.userName,
                password = u.password,
                userId = u.userId
            };
        }

    }
}
