using Item.IRepository.IAudit;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Audit
{
    //离职审批
    public class DimissionRepository:BaseRepository<Dimission_approval>, IDimissionRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Dimission_approval> Show(string sql)
        {
            List<Dimission_approval> dimission_Approvals = Show(sql);
            return dimission_Approvals;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
