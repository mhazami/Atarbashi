using Atarbashi.DataStructure;
using Azami.Framework.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Atarbashi.DAL
{
    public class RoleMenuDA
    {
        private DbContextManager db = new DbContextManager();

        public List<Menu> GetMenuByUserId(string roleList)
        {
            string query = $"SELECT Security.Menu.Id, Security.Menu.Title, Security.Menu.[Order], Security.Menu.ParentId, Security.Menu.IsShow, Security.Menu.Enable, Security.Menu.Icon FROM JOIN Security.Menu.Id = Security.RoleMenu.MenuId Where Security.RoleMenu.RoleId IN ({roleList})";
            List<Menu> menus = db.Set<Menu>().SqlQuery(query).ToList();
            return menus;
        }

        public List<Menu> GetMenuByParentId(string roleList, Guid menuId)
        {
            string query = $"SELECT Security.Menu.Id, Security.Menu.Title, Security.Menu.[Order], Security.Menu.ParentId, Security.Menu.IsShow, Security.Menu.Enable, Security.Menu.Icon FROM JOIN Security.Menu.Id = Security.RoleMenu.MenuId Where Security.Menu.ParentId = '{menuId}' And Security.RoleMenu.RoleId IN ({roleList})";
            List<Menu> menus = db.Set<Menu>().SqlQuery(query).ToList();
            return menus;
        }
    }
}
