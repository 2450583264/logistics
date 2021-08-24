using Item.IRepository.IPersonnel;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Personnel
{
    //入职办理
    public class EntryResponse:BaseRepository<Entry>, IEntryResponse
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Entry> Show(string sql)
        {
            List<Entry> entries = Show(sql);
            return entries;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
