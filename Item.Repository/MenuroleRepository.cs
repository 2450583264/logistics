using Item.IRepository;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository
{
    public class MenuroleRepository:BaseRepository<Menurole>, IMenutroleRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Menurole> Show(string sql)
        {
            List<Menurole> menuroles = Show(sql);
            return menuroles;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
