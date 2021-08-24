using Item.IRepository.IFinance;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Finance
{
    //应收费用
    public class ReceivableRepository:BaseRepository<Receivable>, IReceivableRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Receivable> Show(string sql)
        {
            List<Receivable> receivables = Show(sql);
            return receivables;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
