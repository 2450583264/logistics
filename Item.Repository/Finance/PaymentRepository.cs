using Item.IRepository.IFinance;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Finance
{
    //付款管理
    public class PaymentRepository:BaseRepository<Payment>, IPaymentRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Payment> Show(string sql)
        {
            List<Payment> payments = Show(sql);
            return payments;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
