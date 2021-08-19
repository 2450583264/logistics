using Item.IRepository;
using Item.Model.Model;
using Item.Repository;
using System;
using System.Collections.Generic;

namespace Service
{
    public class MenuService
    {
        IMenuRepository menuRepository;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_menuRepository"></param>
        public MenuService(IMenuRepository _menuRepository)
        {
            menuRepository = _menuRepository;
        }

        public List<Menu> Show()
        {
            string sql = $"select * from Menu";
            List<Menu> list = menuRepository.Show(sql);
            return list;
        }
    }
}
