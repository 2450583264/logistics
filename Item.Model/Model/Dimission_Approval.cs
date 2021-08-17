using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 离职审批表
    /// </summary>
    public class Dimission_approval
    {
        public int Id { get; set; }               //主键
        public string Name { get; set; }          //姓名
        public string Department { get; set; }    //部门
        public string Post { get; set; }          //职位
        public string Principal { get; set; }     //上级负责人
        public DateTime Entry { get; set; }       //入职日期
        public DateTime End_Day { get; set; }     //最后工作日
        public string Cause { get; set; }         //离职原因
        public DateTime Create_Time { get; set; } //创建时间
        public int State { get; set; }            //审批状态
        public string Auditor { get; set; }       //审核人
    }
}
