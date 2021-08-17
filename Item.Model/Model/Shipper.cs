using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 货主表
    /// </summary>
    public class Shipper
    {
        public int ShipperId { get; set; }      //主键
        public string Name { get; set; }        //货主姓名
        public string Phone { get; set; }       //手机号
        public string UnitName { get; set; }    //单位名称
        public string Address { get; set; }     //联系地址
        public DateTime Valid_Time { get; set; }//驾驶证有效日期
        public string Valid_Image { get; set; } //驾驶证照片
        public string Comment { get; set; }     //备注
        public DateTime Creation_Time { get; set; }//创建时间
    }
}
