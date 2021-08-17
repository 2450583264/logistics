using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 菜单角色表
    /// </summary>
    public class Menurole
    {
        public int MenuroleId { get; set; } //主键
        public int MenuId { get; set; }     //菜单外键

        public int Role { get; set; }       //角色
    }
}
