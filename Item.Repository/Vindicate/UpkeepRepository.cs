using Item.IRepository.IVindicate;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Vindicate
{
    //保养记录
    public class UpkeepRepository:BaseRepository<Upkeep>, IUpkeepRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Upkeep> Show(string sql)
        {
            List<Upkeep> upkeeps = Show(sql);
            return upkeeps;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
