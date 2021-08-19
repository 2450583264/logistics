using Item.IRepository.Basic;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Basic
{
    public class OutsourceRepository:BaseRepository<Outsource>, IOutsourceRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Outsource> Show(string sql)
        {
            List<Outsource> outsources = Show(sql);
            return outsources;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
