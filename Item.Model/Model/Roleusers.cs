using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 角色菜单表
    /// </summary>
    public class Roleusers
    {
        public int RoleuserId { get; set; } //主键
        public int RoleId { get; set; }     //角色外键
        public int UsersId { get; set; }    //用户外键
    }
}
