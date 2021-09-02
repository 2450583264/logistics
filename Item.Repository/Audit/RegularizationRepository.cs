using Item.IRepository.IAudit;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Audit
{
    //转正审批
    public class RegularizationRepository:BaseRepository<Regularization_Approval>, IRegularizationRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Regularization_Approval> Show(string sql)
        {
            List<Regularization_Approval> regularization_Approvals = Show(sql);
            return regularization_Approvals;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
