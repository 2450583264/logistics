using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.IRepository.IAudit
{
    /// <summary>
    /// 付款审批
    /// </summary>
    public interface IPaymentRepository:IBaseRepository<Payment_approval>
    {
    }
}
