using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 通用审批表
    /// </summary>
    public class General_approval
    {
        public int Id { get; set; }                  //主键
        public string SerialId { get; set; }         //合同编号
        public string Title { get; set; }            //合同标题
        public string Unit { get; set; }             //对方单位
        public string Principal { get; set; }        //对方负责人
        public string Type { get; set; }             //合同类别
        public DateTime Signed_Time { get; set; }    //签订日期
        public string Operator_g { get; set; }       //经办人
        public DateTime Create_Time { get; set; }    //创建时间
        public int State { get; set; }               //状态
        public string Auditor { get; set; }          //审批人
    }
}
