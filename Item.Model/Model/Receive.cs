using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 物质领用表
    /// </summary>
    public class Receive
    {
        public int Id { get; set; }                 //主键
        public string Name { get; set; }            //标题
        public string Useis { get; set; }           //用途描述
        public string Comment { get; set; }         //备注
        public string Select { get; set; }          //选择
        public string Recipient { get; set; }       //领用人
        public DateTime Receive_Time { get; set; }  //领用时间
        public DateTime Create_Time { get; set; }   //创建时间
        public int State { get; set; }              //审批状态
        public string Approver { get; set; }        //审批人
    }
}
