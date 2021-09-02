using Item.IRepository;
using Item.IRepository.IFinance;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Finance
{
    //应付费用
    public class Cope_withRepository : BaseRepository<Cope_With>, ICope_withRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Cope_With> Show(string sql)
        {
            List<Cope_With> cope_Withs = Show(sql);
            return cope_Withs;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
