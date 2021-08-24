using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.IRepository
{
    //用户
    public interface IUsersRepository:IBaseRepository<Users>
    {
        //登录
        List<Users> Login(string sql,object param = null);  
    }
}
