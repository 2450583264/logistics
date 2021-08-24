using Item.IRepository.IVindicate;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Vindicate
{
    //费用记录
    public class CostRepository:BaseRepository<Cost>, ICostRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Cost> Show(string sql)
        {
            List<Cost> costs = Show(sql);
            return costs;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
