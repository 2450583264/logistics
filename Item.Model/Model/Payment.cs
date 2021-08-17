using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 付款管理表
    /// </summary>
    public class Payment
    {
        public int Id { get; set; }                 //主键        
        public string Name { get; set; }            //标题
        public float Money { get; set; }            //付款金额
        public int Way { get; set; }                //结算方式
        public string Pay_name { get; set; }        //支付对象
        public string Opening_bank { get; set; }    //开户行
        public string Card_number { get; set; }     //银行账单  
        public DateTime Payment_time { get; set; }  //付款日期
        public string Describe { get; set; }        //用途描述
        public string Comment { get; set; }         //备注
        public string Image { get; set; }           //票据附件
        public string Proposer { get; set; }        //申请人
        public DateTime Create_time { get; set; }   //创建时间
        public int State { get; set; }              //审批状态
    }
}
