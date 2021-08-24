using Item.IRepository.IContract;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Contract
{
    //货主合同
    public class ShipperRepository:BaseRepository<Shippercontract>, IShipperRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Shippercontract> Show(string sql)
        {
            List<Shippercontract> shippercontracts = Show(sql);
            return shippercontracts;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
