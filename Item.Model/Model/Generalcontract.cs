using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 通用合同表
    /// </summary>
    public class Generalcontract
    {
        public int Id { get; set; }             //主键
        public string ContracId { get; set; }   //合同编号
        public string Name { get; set; }        //合同标题
        public string Unit { get; set; }        //对方单位
        public string Principal { get; set; }   //对方负者人
        public int Category { get; set; }       //合作类别
        public DateTime Signed_Time { get; set; }//签订时间
        public string Agent { get; set; }        //经办人
        public float Contract_Money { get; set; }//合同金额
        public string Contract_Intro { get; set; }//合同说明
        public string Clause { get; set; }      //合同条款
        public string Contract_Text { get; set; }//合同文本
        public DateTime Creation_Time { get; set; }//创建时间
        public bool State { get; set; }         //状态
        public string Approver { get; set; }    //审批人
    }
}
