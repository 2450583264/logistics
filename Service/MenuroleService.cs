using Item.IRepository;
using Item.Model.Model;
using Item.Repository;
using System;
using System.Collections.Generic;


namespace Service
{
    /// <summary>
    /// 菜单角色服务成
    /// </summary>
    public class MenuroleService
    {
        IMenutroleRepository menutroleRepository;
        public MenuroleService(IMenutroleRepository _menutroleRepository) {
            menutroleRepository = _menutroleRepository;
        }
        public List<Menurole> showMenurole(int RoleId) {
            string sql = "select menu.menuId,menu.menuName,menu.menuWId from menutrole join menu on menutrole.menuId=menu.menuId where roleId=@RoleId";
            List<Menurole> list = menutroleRepository.Show(sql,new { @RoleId =RoleId});
            return list;

        }
        
    }
}
