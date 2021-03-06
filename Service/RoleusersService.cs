using Item.IRepository;
using Item.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Item.Model.Model;

namespace Service
{
    public class RoleusersService : RoleusersRepository
    {
        IRoleusersRepository roleusersRepository;
        public RoleusersService(IRoleusersRepository _roleusersRepository)
        {
            roleusersRepository = _roleusersRepository;
        }
        public List<Roleusers> ShowRoleusers(int Id) {
            string sql = "select * from Roleusers where usersId=@usersId";
            List<Roleusers> list = roleusersRepository.Show(sql, new { @usersId=Id });
            return list;
        }
    }
}
