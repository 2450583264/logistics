using Item.IRepository.Basic;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Basic
{
    public class PathRepository : BaseRepository<Path>, IPathRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Path> Show(string sql)
        {
            List<Path> paths = Show(sql);
            return paths;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
