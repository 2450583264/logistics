
using Item.IRepository.IPersonnel;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Personnel
{
    //员工登记
    public class StaffRepository:BaseRepository<Staff>, IStaffRepository
    {

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Staff> Show(string sql)
        {
            List<Staff> staffs = Show(sql);
            return staffs;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
