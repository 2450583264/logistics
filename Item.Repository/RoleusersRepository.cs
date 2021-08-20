using Item.IRepository;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository
{
    public class RoleusersRepository:BaseRepository<Roleusers>, IRoleusersRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Roleusers> Show(string sql)
        {
            List<Roleusers> roleusers = Show(sql);
            return roleusers;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
