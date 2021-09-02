using Item.IRepository.IMatter;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Matter
{
    //物质领用
    public class ReceiveRepository:BaseRepository<Receive>, IReceiveRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Receive> Show(string sql)
        {
            List<Receive> receives = Show(sql);
            return receives;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
