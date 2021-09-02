using Item.IRepository.IFinance;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Finance
{
    //销项发票
    public class OutputRepository:BaseRepository<Output>, IOutputRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Output> Show(string sql)
        {
            List<Output> outputs = Show(sql);
            return outputs;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
