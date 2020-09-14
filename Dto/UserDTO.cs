using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
 public   class UserDTO
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string contactsList { get; set; }

        public UserDTO()
        {

        }
        public UserDTO(Dal.User u)
        {
            userId = u.userId;
            userName = u.userName;
            password = u.password;
            email = u.email;
            contactsList = u.contactsList;
        }
        public static Dal.User ToDal(Dto.UserDTO u)
        {
            Dal.User user = new Dal.User
            {
                contactsList = u.contactsList,
                email = u.email,
                password = u.password,
                userName = u.userName,
                userId = u.userId
            };
            return user;
        }

    }
}
