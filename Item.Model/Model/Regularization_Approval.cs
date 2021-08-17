using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 转正审批表
    /// </summary>
    public class Regularization_Approval
    {
        public int Id { get; set; }                //主键
        public string Name { get; set; }           //姓名
        public string Department { get; set; }     //部门
        public string Post { get; set; }           //职位
        public DateTime Entry { get; set; }        //入职日期
        public DateTime Apply_For { get; set; }    //申请日期
        public int State { get; set; }             //审批状态
        public string Auditor { get; set; }        //审批人
        public DateTime Create_Time { get; set; }  //创建时间
    }
}
