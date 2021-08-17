using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 货主合同跟踪
    /// </summary>
    public class Shipper_Track
    {
        public int Id { get; set; }                 //主键
        public string Contract_Id { get; set; }     //合同编号
        public string Title { get; set; }           //合同标题
        public string Unit { get; set; }            //货主单位
        public string Principal { get; set; }       //货主负责人
        public string Path { get; set; }            //路线
        public float Fare { get; set; }             //吨位价
        public int Condition { get; set; }          //包车条件吨位
        public float Money { get; set; }            //包车金额
        public DateTime Signed_Time { get; set; }   //签订日期
        public string Operator_g { get; set; }      //经办人
        public DateTime Create_Time { get; set; }   //创建时间
        public string Anomaly { get; set; }         //异常警报
        public bool State { get; set; }             //货物状态
    }
}
