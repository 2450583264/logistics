using System;
using System.Collections.Generic;

namespace Item.IRepository
{
    /// <summary>
    /// dapper接口CRUD
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseRepository<T> where T : class, new()
    {
        int RUD(string sql, object param = null);

        List<T> Show(string sql, object param = null);

    }

}
