using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Item.Model;
using Item.Model.Model;
using Item.Repository.Audit;

namespace Service.AuditService
{
    //通用审批Service
    public class PaymentService
    {
        private PaymentRepository paymentRepository;

        public PaymentService(PaymentRepository _paymentRepository)
        {
            paymentRepository = _paymentRepository;
        }
        //显示
        public Result Show()
        {
            string sql = "select * from Procurement_approval";
            List<Payment_approval> payment_approval = paymentRepository.Show(sql);
            Result result = new Result();
            result.Code = 200;
            result.Data = payment_approval;
            result.Msg = "查询成功";
            return result;
        }
        //添加
        public Result Add(Payment_approval payment_Approval)
        {
            string sql = $"insert into payment_Approval values(null,@title,@describe,@money,@way,@pay_object,@opening,@card_number,@apply_for,@payment,@comment,@create_time,@state,@auditor)";
            Result result = new Result();
            bool _bool = paymentRepository.RUD(sql, new
            {
                @title = payment_Approval.Title,
                @describe = payment_Approval.Describe,
                @money = payment_Approval.Money,
                @way = payment_Approval.Way,
                @pay_object = payment_Approval.Pay_Object,
                @opening = payment_Approval.Opening,
                @card_number = payment_Approval.Card_Number,
                @apply_for = payment_Approval.Apply_For,
                @payment = payment_Approval.Payment,
                @comment = payment_Approval.Comment,
                @create_time = payment_Approval.Create_Time,
                @state = payment_Approval.State,
                @auditor = payment_Approval.Auditor
            });
            if (_bool == true)
            {
                result.Msg = "添加成功";
                result.Code = 200;
            }
            else
            {
                result.Msg = "添加失败";
                result.Code = 500;
            }
            return result;
        }
        //批删（可用于单删）
        public Result Delect(string Id)
        {
            string sql = "delete from payment_Approval where id in(@id)";
            Result result = new Result();
            bool _bool = paymentRepository.RUD(sql, new { @id = Id });
            if (_bool == true)
            {

                result.Msg = "删除成功";
                result.Code = 200;
            }
            else
            {
                result.Msg = "删除失败";
                result.Code = 500;
            }
            return result;

        }
        //修改
        public Result Update(Payment_approval payment_Approval, int Id)
        {
            string sql = " update payment_Approval set title=@title,describe=@describe,money=@money,way=@way,pay_object=@pay_object,opening=@opening,card_number=@card_number,apply_for=@apply_for,payment=@payment,comment=@comment,create_time=@create_time,state=@state,auditor=@auditor where id=@id";
            Result result = new Result();
            bool _bool = paymentRepository.RUD(sql, new
            {
                @title = payment_Approval.Title,
                @describe = payment_Approval.Describe,
                @money = payment_Approval.Money,
                @way = payment_Approval.Way,
                @pay_object = payment_Approval.Pay_Object,
                @opening = payment_Approval.Opening,
                @card_number = payment_Approval.Card_Number,
                @apply_for = payment_Approval.Apply_For,
                @payment = payment_Approval.Payment,
                @comment = payment_Approval.Comment,
                @create_time = payment_Approval.Create_Time,
                @state = payment_Approval.State,
                @auditor = payment_Approval.Auditor,
                @id = Id
            });
            if (_bool == true)
            {
                result.Msg = "修改成功";
                result.Code = 200;
            }
            else
            {
                result.Msg = "修改失败";
                result.Code = 500;
            }
            return result;

        }
    }
}
