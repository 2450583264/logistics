using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 承运合同表
    /// </summary>
    public class Carriagecontract
    {
        public int Id { get; set; }                     //主键
        public string ContractId { get; set; }          //合同编号
        public string Name { get; set; }                //合同协议
        public string Unit { get; set; }                //外协单位
        public string Principal { get; set; }           //外协负责人
        public string Path { get; set; }                //路线
        public float Price { get; set; }                //吨位价
        public int Full_Price { get; set; }             //包车条件吨位
        public int Full_Money { get; set; }             //包车金额
        public DateTime Signing_Time { get; set; }      //签订日期
        public string Agent { get; set; }               //经办人
        public DateTime Creation_Time { get; set; }     //创建时间
        public bool State { get; set; }                 //状态
        public string Approval { get; set; }            //审批人
        public float Contract_Time { get; set; }        //合同金额
        public string Contract_Explain { get; set; }    //合同说明
        public string Contract_Clause { get; set; }     //合同条款
        public string Contract_Text { get; set; }       //合同文本
    }
}
