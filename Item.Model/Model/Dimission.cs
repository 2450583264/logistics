using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 离职办理表
    /// </summary>
    public class Dimission
    {
        public int Id { get; set; }             //主键
        public string Name { get; set; }        //姓名
        public int Department { get; set; }     //性别
        public int Post { get; set; }           //部门
        public string Superior { get; set; }    //上级负责人
        public DateTime Entry_Time { get; set; }//入职日期
        public DateTime End_Day { get; set; }   //创建时间
        public string Cause { get; set; }       //审核状态
        public int State { get; set; }          //审核人
        public DateTime Create_Time { get; set; }//备注
    }
}
