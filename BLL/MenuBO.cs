using Atarbashi.DataStructure;
using Azami.Framework.BO;
using System;
using System.Collections.Generic;

namespace Atarbashi.BLL
{
    public class MenuBO : BaseBO<Menu>
    {

        public List<Menu> GetMenuByUserId(Guid userId)
        {
            var menus= new RoleMenuBO().GetMenuByUserId(userId);
            return menus;
        }

        public List<Menu> GetMenuByParentId(Guid menuId ,Guid userId)
        {
            var menus = new RoleMenuBO().GetMenuByParentId(menuId,userId);
            return menus;
        }
    }

}
