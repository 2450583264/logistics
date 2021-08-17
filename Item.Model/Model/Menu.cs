using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 菜单表
    /// </summary>
   public class Menu
    {
        public int MenuId { get; set; }     //主键
        public string MenuName { get; set; }   //菜单名称
        public int MenuWId { get; set; }        //下级菜单
    }
}
