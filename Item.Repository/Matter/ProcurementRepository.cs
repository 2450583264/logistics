using Item.IRepository.IMatter;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Matter
{
    //物质采购
    public class ProcurementRepository:BaseRepository<Procurement>, IProcurementRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Procurement> Show(string sql)
        {
            List<Procurement> procurements = Show(sql);
            return procurements;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
