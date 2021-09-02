using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.IRepository.IAudit
{
    /// <summary>
    /// 货主审批
    /// </summary>
    public interface IShipperRepository:IBaseRepository<Shipper_approval>
    {
    }
}
