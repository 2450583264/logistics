using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 车辆表
    /// </summary>
    public class Vehicle
    {
        public int VehicleId { get; set; }          //主键
        public string BrandId { get; set; }         //厂牌型号
        public string Plate_Number { get; set; }    //车牌号
        public string Name { get; set; }            //司机姓名
        public string Company { get; set; }         //所属公司
        public float @long  { get; set; }          //车型长
        public float Wide { get; set; }             //宽
        public float Tall { get; set; }             //高
        public string Color { get; set; }           //车辆颜色
        public DateTime Buy_Tiem { get; set; }      //购置日期
        public string Certificate { get; set; }     //保险到期时间
        public DateTime Expire_Time { get; set; }   //运营
        public DateTime Yearexpire_Time { get; set; }//年检到期时间
        public string Maintain { get; set; }        //保养公里设置
        public string Vehicle_Image { get; set; }   //车辆照片
        public string Insurance_Image { get; set; } //保险卡照片
    }
}
