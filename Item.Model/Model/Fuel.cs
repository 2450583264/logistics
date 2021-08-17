using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 油费表
    /// </summary>
    public class Fuel
    {
        public int FuelId { get; set; }             //主键
        public string Plate_number { get; set; }    //车牌号
        public double Cost { get; set; }            //加油费用
        public int Oil_Mass { get; set; }           //加油量
        public int Km { get; set; }                 //起始公里数
        public int Pay { get; set; }                //支付方式
        public string Broker { get; set; }          //经办人
        public string Comment { get; set; }         //备注
        public DateTime Creation_Time { get; set; } //创建时间
    }
}
