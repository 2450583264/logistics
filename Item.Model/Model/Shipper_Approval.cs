using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 货主审批表
    /// </summary>
    public class Shipper_approval
    {
        public int Id { get; set; }                     //主键
        public string SerialId { get; set; }            //合同编号
        public string Title { get; set; }               //合同标题
        public int Unit { get; set; }                   //货主单位
        public string Principal { get; set; }           //货主负责人
        public string Path { get; set; }                //路线
        public float Price { get; set; }                //吨运价
        public int Full_Price { get; set; }             //包车条件吨位
        public float Money { get; set; }                //包车金额
        public DateTime Signed_Time { get; set; }       //签订日期
        public string Operator_g    { get; set; }       //经办人
        public DateTime Create_Time { get; set; }       //创建时间
        public int State { get; set; }                  //状态
        public string Auditor { get; set; }             //审核人
    }
}
