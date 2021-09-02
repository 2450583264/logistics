using Item.IRepository.IPersonnel;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Personnel
{
    //离职办理
    public class DimissionResponse:BaseRepository<Dimission>, IDimissionResponse
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Dimission> Show(string sql)
        {
            List<Dimission> dimissions = Show(sql);
            return dimissions;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
