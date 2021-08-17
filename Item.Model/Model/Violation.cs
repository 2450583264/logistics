using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 违章记录表
    /// </summary>
    public class Violation
    {
        public int Id { get; set; }                     //主键
        public string Title { get; set; }               //违章记录
        public string License_Plate { get; set; }       //车牌号
        public string Violation_Name { get; set; }      //违章人
        public DateTime Violation_Date { get; set; }    //违章日期
        public string Violation_Intro { get; set; }     //违章内容
        public string Result { get; set; }              //处理结果
        public string Comment { get; set; }             //备注
        public DateTime Create_Time { get; set; }       //创建时间
    }
}
