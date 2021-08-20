using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Item.IRepository;
using Item.Common.DB;

namespace Item.Repository
{

    public class MenuRepository : BaseRepository<Menu>, IMenuRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Menu> Show(string sql)
        {
            List<Menu> menus = Show(sql);
            return menus;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }

}
