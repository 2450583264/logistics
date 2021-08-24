using Item.IRepository.IAudit;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Audit
{
    //通用审批
    public class GeneralRepository:BaseRepository<General_approval>, IGeneralRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<General_approval> Show(string sql)
        {
            List<General_approval> general_Approvals = Show(sql);
            return general_Approvals;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
