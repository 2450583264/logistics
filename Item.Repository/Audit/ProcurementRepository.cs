using Item.IRepository.IAudit;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Audit
{
    //采购审批
    public class ProcurementRepository:BaseRepository<Procurement_approval>, IProcurementRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Procurement_approval> Show(string sql)
        {
            List<Procurement_approval> procurement_Approvals = Show(sql);
            return procurement_Approvals;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
