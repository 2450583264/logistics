using Item.Common.DB;
using Item.IRepository.Basic;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Basic
{
    public class VehicleRepository: BaseRepository<Vehicle>,IVehicleRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Vehicle> Show(string sql) { 
            List<Vehicle> vehicles = Show(sql);
            return vehicles;
        }

        public bool RUD(string sql) {
            bool _bool = RUD(sql);
            return _bool;
        }

    }
}
