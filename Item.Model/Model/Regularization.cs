using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 转正办理表
    /// </summary>
    public class Regularization
    {
        public int Id { get; set; }                 //主键
        public string Name { get; set; }            //姓名
        public int Department { get; set; }         //部门
        public int Position { get; set; }           //职位
        public string Superior { get; set; }        //上级负责人
        public DateTime Entry_Time { get; set; }    //入职时间
        public DateTime Applyfor_Time { get; set; } //申请日期  
        public bool State { get; set; }             //审批状态
        public string Sum_Up { get; set; }          //使用期工作总结
        public string Suggest { get; set; }         //对公司的建议
        public DateTime Create_Time { get; set; }   //创建时间
    }
}
