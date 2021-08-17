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
        public List<Users> Login(string Admin, string Pwd)
        {
            string sql = $"select * from Users where admin=@Admin and pwd=@Pwd";
            List<Users> data = Dapper<Users>.Query(sql, new { @Admin=Admin,@Pwd=Pwd });
            return data;
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
