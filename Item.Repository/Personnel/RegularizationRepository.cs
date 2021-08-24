using Item.IRepository.IPersonnel;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Personnel
{
    //转正办理
    public class RegularizationRepository:BaseRepository<Regularization>, IRegularizationRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Regularization> Show(string sql)
        {
            List<Regularization> regularizations = Show(sql);
            return regularizations;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
