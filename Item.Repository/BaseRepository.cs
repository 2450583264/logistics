using Item.Common.DB;
using Item.IRepository;
using System;
using System.Collections.Generic;

namespace Item.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public int RUD(string sql, object param = null)
        {
            return Dapper<T>.RUD(sql, param);
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<T> Show(string sql, object param = null)
        {
            List<T> list = Dapper<T>.Query(sql, param);
            return list;
        }

    }
}
