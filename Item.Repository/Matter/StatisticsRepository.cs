using Item.IRepository.IMatter;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Matter
{
    //物质统计
    public class StatisticsRepository:BaseRepository<Statistics>, IStatisticsRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Statistics> Show(string sql)
        {
            List<Statistics> statistics = Show(sql);
            return statistics;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
