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
        public string password { get; set; }
        public string email { get; set; }
        public string contactsList { get; set; }

        public UserDTO()
        {

        }
        public UserDTO(User u)
        {
            userId = u.userId;
            password = u.password;
            email = u.email;
            contactsList = u.contactsList;
        }
        public static User ToDal(UserDTO u)
        {
            User user = new User
            {
                contactsList = u.contactsList,
                email = u.email,
                password = u.password,
                userId = u.userId
            };
            return user;
        }

    }
}
