using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class GroupsDTO
    {
        public int id { get; set; }
        public string groupName { get; set; }

        public GroupsDTO()
        {
                
        }

        public GroupsDTO(Dal.Group g)
        {
            id = g.id;
            groupName = g.groupName;
        }

        public static List<GroupsDTO> ConvertToListDto(List<Dal.Group> lst)
        {
            return lst.Select(g => new GroupsDTO(g)).ToList();
        }

        public static Dal.Group ToDal(GroupsDTO g)
        {
            return new Dal.Group
            {
                id = g.id,
                groupName = g.groupName
            };
        }
    }
}
