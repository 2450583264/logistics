using Item.IRepository;
using Item.Model.Model;
using Item.Repository;
using System;
using System.Collections.Generic;

namespace Service
{
    public class UsersService
    {
        IUsersRepository usersRepository;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_usersRepository"></param>
        public UsersService(IUsersRepository _usersRepository)
        {
            usersRepository = _usersRepository;
        }

        public List<Users> Show()
        {
            string sql = $"select * from Users";
            List<Users> list = usersRepository.Show(sql);
            return list;
        }
        public List<Users> Login(string Admin, string Pwd) {
            string sql = "select * from users where Admin=@Admin and Pwd=@Pwd";
            return usersRepository.Login(sql, new { @Admin = Admin, @Pwd = Pwd });
        }
    }
}
