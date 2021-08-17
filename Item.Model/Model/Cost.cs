using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 费用记录表
    /// </summary>
    public class Cost
    {
        public int Id { get; set; }                 //主键
        public string Title { get; set; }           //费用标题  
        public string Type { get; set; }            //费用类型
        public string License_Plate { get; set; }   //车牌号
        public float Money { get; set; }            //金额
        public string Principal { get; set; }       //负责人   
        public string Describe { get; set; }        //描述
        public DateTime Use_Time { get; set; }      //使用日期
        public string Comment { get; set; }         //备注
        public DateTime Create_Time { get; set; }   //创建时间
    }
}
