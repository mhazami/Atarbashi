using Atarbashi.DataStructure;
using Azami.Framework.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Atarbashi.BLL
{
    public class MenuBO : BaseBO<Menu>
    {

        public List<Menu> GetMenuByUserId(Guid userId)
        {
            List<Guid> roles = new UserRoleBO().Select(x => x.RoleId, x => x.UserId == userId, true);

            var roleList = string.Join(",", roles.Select(i => i.ToString()));

            var query = $"SELECT MenuId From [Security].[RoleMenu] Where RoleId IN ({roleList})";
            int amount = db.Database.SqlQuery<int>(query).Single(); 
        }
    }
    }
}
