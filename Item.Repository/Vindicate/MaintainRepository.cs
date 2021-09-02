
using Item.IRepository.IVindicate;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Vindicate
{
    //维修记录
    public class MaintainRepository:BaseRepository<Maintain>, IMaintainRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Maintain> Show(string sql)
        {
            List<Maintain> maintains = Show(sql);
            return maintains;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
