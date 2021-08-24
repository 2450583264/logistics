using Item.IRepository.IAudit;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Audit
{
    //承运审批
    public class CarriagerRepository:BaseRepository<Carriage_approval>, ICarriagerRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Carriage_approval> Show(string sql)
        {
            List<Carriage_approval> carriage_Approvals = Show(sql);
            return carriage_Approvals;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
