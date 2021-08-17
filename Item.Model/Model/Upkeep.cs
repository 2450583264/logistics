using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 保养记录表
    /// </summary>
    public class Upkeep
    {
        public int Id { get; set; }                 //主键
        public string Name { get; set; }            //保养标题
        public string License_Plate { get; set; }   //车牌号
        public float Money { get; set; }            //保养金额
        public string Principal { get; set; }       //保养负责人
        public int Mileage { get; set; }            //当前里程数
        public DateTime Maintain_Time { get; set; } //上次保养日期
        public int Maintain_Mileage { get; set; }   //上次保养里程数
        public DateTime New_Mileage { get; set; }   //当前保养日期
        public string Maintain_Item { get; set; }   //保养项目
        public string Comment { get; set; }         //备注
        public DateTime Create_Time { get; set; }   //创建时间
    }
}
