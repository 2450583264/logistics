using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 入职办理表
    /// </summary>
    public class Entry
    {
        public int Id { get; set; }             //主键
        public string Name { get; set; }        //姓名
        public bool Sex { get; set; }           //性别
        public int Department { get; set; }     //部门
        public int Post { get; set; }           //职位
        public string Superior { get; set; }    //上级领导人
        public DateTime Entry_Time { get; set; }//入职日期
        public DateTime Establish_Time { get; set; }//创建时间
        public bool State { get; set; }             //审核状态
        public string Audit { get; set; }           //审核人
        public string Comment { get; set; }         //备注
    }
}
