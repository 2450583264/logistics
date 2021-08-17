using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 维修记录表
    /// </summary>
    public class Maintain
    {
        public int Id { get; set; }                 //主键
        public string Name { get; set; }            //维修标题
        public string Type { get; set; }            //维修类型
        public string License_Plate { get; set; }   //车牌号
        public float Money { get; set; }            //维修金额
        public string Principal { get; set; }       //维修负责人
        public string Describe { get; set; }        //维修描述
        public DateTime Maintain_Time { get; set; } //维修日期
        public string Comment { get; set; }         //备注
        public DateTime Create_Time { get; set; }   //创建日期
    }
}
