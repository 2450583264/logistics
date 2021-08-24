using Item.IRepository.IContract;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Contract
{
    //承运合同
    public class CarriageRepository:BaseRepository<Carriagecontract>, ICarriageRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Carriagecontract> Show(string sql)
        {
            List<Carriagecontract> carriagecontracts = Show(sql);
            return carriagecontracts;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
