using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 销项发票表
    /// </summary>
    public class Output
    {
        public int Id { get; set; }                 //主键
        public string InvoiceId { get; set; }       //发票号
        public string Unit { get; set; }            //客户名称
        public int State { get; set; }              //发票类型
        public float Money { get; set; }            //发票金额
        public float Tax_Rate { get; set; }         //税率
        public float Tax { get; set; }              //税额
        public DateTime Invoice_Time { get; set; }  //开票日期
        public string Comment { get; set; }         //备注
        public string Single { get; set; }          //制单人
        public DateTime Create_Time { get; set; }   //创建时间
    }
}
