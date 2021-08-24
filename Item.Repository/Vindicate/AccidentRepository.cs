using Item.IRepository.IVindicate;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Vindicate
{
    //事故记录
    public class AccidentRepository:BaseRepository<Accident>, IAccidentRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Accident> Show(string sql)
        {
            List<Accident> accidents = Show(sql);
            return accidents;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
