using Item.IRepository.Basic;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Basic
{
    public class FuelRepository : BaseRepository<Fuel>, IFuelRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Fuel> Show(string sql)
        {
            List<Fuel> fuels = Show(sql);
            return fuels;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
