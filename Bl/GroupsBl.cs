using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class GroupsBl
    {

        public static List<Dto.GroupsDTO> GetAllGroups()
        {
            return Dto.GroupsDTO.ConvertToListDto(Dal.GroupsDal.GetAllGroups());
        }

        public static Dto.GroupsDTO CreateNewGroup(Dto.GroupsDTO group)
        {
            //בודק אם קיימת כבר קבוצה בשם זה אם לא - מכניסה לדטבייס אם כבר יש- מחזיר פולס
            var g1 = (Dal.GroupsDal.GetAllGroups().Where(g => g.groupName == group.groupName).FirstOrDefault());
            if (g1 == null)
            { 
               g1 = Dal.GroupsDal.Add(Dto.GroupsDTO.ToDal(group));
               return new Dto.GroupsDTO(g1);
            }
            return null;
        }

        public static bool UpdateGroup(Dto.GroupsDTO group)
        {
            return Dal.GroupsDal.Put(Dto.GroupsDTO.ToDal(group));
        }

        public static bool DeleteGroup(Dto.GroupsDTO group)
        {
            return Dal.GroupsDal.Delete(Dto.GroupsDTO.ToDal(group));
        }
    }
}
