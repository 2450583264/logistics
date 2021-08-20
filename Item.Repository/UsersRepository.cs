using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Item.IRepository;
using Item.Common.DB;

namespace Item.Repository
{

    public class UsersRepository : BaseRepository<Users>, IUsersRepository
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Users> Login(string sql, object param)
        {
            List<Users> data = Dapper<Users>.Query(sql,param);
            return data;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Users> Show(string sql)
        {
            List<Users> users = Show(sql);
            return users;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }

    }


    //明天看
    //public List<UserModel> UserLogin(string UserName, string UserPwd)
    //{
    //    string sql = "select * from UserModel where UserName=@UserName and UserPwd=@UserPwd";
    //    List<UserModel> Data = Dapper<UserModel>.Query(sql, new { @UserName = UserName, @UserPwd = UserPwd });
    //    return Data;
    //}
}
