using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto
{
    public class ContactsDTO
    {
        public int userId { get; set; }
        public int memberId { get; set; }
        public string memberName { get; set; }
        public string memberEmail { get; set; }
        public Nullable<int> groupId { get; set; }


        public ContactsDTO()
        {

        }

        public ContactsDTO(Contact c)
        {
            userId = c.userId;
            memberId = c.memberId;
            memberName = c.memberName;
            memberEmail = c.memberEmail;
            groupId = c.groupId;
        }

        public static List<ContactsDTO> ConvertToListDto(List<Dal.Contact> lst)
        {
            return lst.Select(c => new ContactsDTO(c)).ToList();
        }

        public static Contact ToDal(ContactsDTO c)
        {
            return new Dal.Contact
            {
                userId = c.userId,
                memberId = c.memberId,
                memberName = c.memberName,
                memberEmail = c.memberEmail,
                groupId = c.groupId
            };
        }
    }
}

