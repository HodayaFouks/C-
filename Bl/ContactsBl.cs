using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Bl
{
    public class ContactsBl
    {
        public static List<Dto.ContactsDTO> GetContactsByUserId(int userId)
        {
            return ContactsDTO.ConvertToListDto(Dal.ContactsDal.GetContactsByUserId(userId));
        }

        public static bool UpdateContact(Dto.ContactsDTO contact)
        {
            return Dal.ContactsDal.Put(Dto.ContactsDTO.ToDal(contact));
        }

        public static bool DeleteContact(Dto.ContactsDTO contact)
        {
            return Dal.ContactsDal.Delete(Dto.ContactsDTO.ToDal(contact));
        }


    }
}
