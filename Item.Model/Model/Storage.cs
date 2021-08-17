using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 入库管理表
    /// </summary>
    public class Storage
    {
        public int Id { get; set; }                 //主键
        public string Name { get; set; }            //货物名称
        public int Way_Money { get; set; }          //支付方式
        public string Type { get; set; }            //类型
        public string Texture { get; set; }         //材质
        public string Scale { get; set; }           //规模
        public string Origin { get; set; }          //产地
        public float Price { get; set; }            //单价
        public int Number { get; set; }             //数量
        public string Comment { get; set; }         //备注
        public float Buying { get; set; }           //采购金额
        public string Registrant { get; set; }      //登记人
        public DateTime Create_Time { get; set; }   //创建时间
    }
}
