using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 外协表
    /// </summary>
    public class Outsource
    {
        public int OutsourceId { get; set; }        //主键
        public string Unit_Name { get; set; }       //外协单位名称
        public string Email { get; set; }           //邮箱
        public string Fixed_Line { get; set; }      //固话
        public string Phone { get; set; }           //手机号
        public string Site { get; set; }            //外协地址
        public DateTime Creation_Time { get; set; } //创建时间
        public string Comment { get; set; }         //备注
    }
}
