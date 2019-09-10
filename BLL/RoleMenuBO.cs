using Atarbashi.DAL;
using Atarbashi.DataStructure;
using Azami.Framework.BO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Atarbashi.BLL
{
    public class RoleMenuBO 
    {
        public List<Menu> GetMenuByUserId(Guid userId)
        {
            List<Guid> roles = new UserRoleBO().Select(x => x.RoleId, x => x.UserId == userId, true);

            var roleList = string.Join(",", roles.Select(i => i.ToString()));
            return new RoleMenuDA().GetMenuByUserId(roleList);
           
        }

        public List<Menu> GetMenuByParentId(Guid menuId, Guid userId)
        {
            List<Guid> roles = new UserRoleBO().Select(x => x.RoleId, x => x.UserId == userId, true);
            var roleList = string.Join(",", roles.Select(i => i.ToString()));
            return new RoleMenuDA().GetMenuByParentId(roleList,menuId);
        }
    }
}
