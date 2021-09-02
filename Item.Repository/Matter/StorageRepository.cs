using Item.IRepository.IMatter;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Matter
{
    //入库管理
    public class StorageRepository:BaseRepository<Storage>, IStorageRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Storage> Show(string sql)
        {
            List<Storage> storages = Show(sql);
            return storages;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
