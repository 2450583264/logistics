using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 领用审批表
    /// </summary>
    public class Receive_approval
    {
        public int Id { get; set; }                     //主键
        public string Title { get; set; }               //领用标题
        public string Describe { get; set; }            //用途描述
        public string Recipient { get; set; }           //领用人
        public DateTime Recipient_Time { get; set; }    //领用日期
        public string Comment { get; set; }             //备注
        public DateTime Create_Time { get; set; }       //创建时间
        public int State { get; set; }                  //状态
        public string Auditor { get; set; }             //审批人
    }
}
