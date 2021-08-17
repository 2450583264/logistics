using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 付款审批表
    /// </summary>
    public class Payment_approval
    {
        public int Id { get; set; }                  //主键
        public string Title { get; set; }            //标题
        public string Describe { get; set; }         //用途描述
        public float Money { get; set; }             //付款金额
        public string Way { get; set; }              //付款方式
        public string Pay_Object { get; set; }       //支付对象
        public string Opening { get; set; }          //开户行
        public string Card_Number { get; set; }      //银行账号
        public string Apply_For { get; set; }        //申请人
        public DateTime Payment { get; set; }        //付款日期
        public string Comment { get; set; }          //备注
        public DateTime Create_Time { get; set; }    //创建时间
        public int State { get; set; }               //审核状态
        public string Auditor { get; set; }          //审批人
    }
}
