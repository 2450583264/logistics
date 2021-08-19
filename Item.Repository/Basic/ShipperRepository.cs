using Item.IRepository.Basic;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Basic
{
    public class ShipperRepository : BaseRepository<Shipper>, IShipperRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Shipper> Show(string sql)
        {
            List<Shipper> shippers = Show(sql);
            return shippers;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
