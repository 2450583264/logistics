using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 应收费用表
    /// </summary>
    public class Receivable
    {
        public int Id { get; set; }             //主键
        public string Odd { get; set; }         //业务单号
        public string Unit { get; set; }        //货主单位
        public int Way { get; set; }            //结算方式
        public int Tonnage { get; set; }        //吨位
        public float Price { get; set; }        //单价
        public float Money { get; set; }        //金额
        public DateTime Business_Time { get; set; }//业务日期
        public string Agent { get; set; }       //经办人
        public string Comment { get; set; }     //备注
        public string Collator { get; set; }    //核对人
        public DateTime Proof_Time { get; set; }//核对时间
        public DateTime Create_Time { get; set; }//创建时间
        public int State { get; set; }          //核对状态
    }
}
