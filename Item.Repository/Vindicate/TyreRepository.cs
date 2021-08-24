using Item.IRepository.IVindicate;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Vindicate
{
    //轮胎使用记录
    public class TyreRepository:BaseRepository<Tyre>, ITyreRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Tyre> Show(string sql)
        {
            List<Tyre> tyres = Show(sql);
            return tyres;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
