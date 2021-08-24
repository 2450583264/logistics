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
    public class ReceiveService
    {
        //领用审批service
        private ReceiveRepository receiveRepository;

        public ReceiveService(ReceiveRepository _receiveRepository) {
            receiveRepository = _receiveRepository;
        }

        //显示
        public Result Show()
        {
            string sql = "select * from procurement_approval";
            List<Receive_approval> receive_approval = receiveRepository.Show(sql);
            Result result = new Result();
            result.Code = 200;
            result.Data = receive_approval;
            result.Msg = "查询成功";
            return result;
        }
        //添加
        public Result Add(Receive_approval receive_Approval)
        {
            string sql = $"insert into receive_Approval values(null,@title,@describe,@recipient,@recipient_time,@comment,@create_time,@state,@auditor)";
            Result result = new Result();
            bool _bool = receiveRepository.RUD(sql, new
            {

                @title = receive_Approval.Title,
                @describe = receive_Approval.Describe,
                @recipient = receive_Approval.Recipient,
                @recipient_time = receive_Approval.Recipient_Time,
                @comment = receive_Approval.Comment,
                @create_time = receive_Approval.Create_Time,
                @state = receive_Approval.State,
                @auditor = receive_Approval.Auditor

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
            string sql = "delete from receive_Approval where id in(@id)";
            Result result = new Result();
            bool _bool = receiveRepository.RUD(sql, new { @id = Id });
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
        public Result Update(Receive_approval receive_Approval, int Id)
        {
            string sql = " update receive_Approval set where id=@id";
            Result result = new Result();
            bool _bool = receiveRepository.RUD(sql, new
            {

                @title = receive_Approval.Title,
                @describe = receive_Approval.Describe,
                @recipient = receive_Approval.Recipient,
                @recipient_time = receive_Approval.Recipient_Time,
                @comment = receive_Approval.Comment,
                @create_time = receive_Approval.Create_Time,
                @state = receive_Approval.State,
                @auditor = receive_Approval.Auditor,
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
