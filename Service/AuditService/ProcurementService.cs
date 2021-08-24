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
    public class ProcurementService
    {
        //采购审批service
        private ProcurementRepository  procurementRepository;

        public ProcurementService(ProcurementRepository _procurementRepository)
        {
            procurementRepository = _procurementRepository;
        }
        //显示
        public Result Show()
        {
            string sql = "select * from procurement_approval";
            List<Procurement_approval> procurement_Approvals = procurementRepository.Show(sql);
            Result result = new Result();
            result.Code = 200;
            result.Data = procurement_Approvals;
            result.Msg = "查询成功";
            return result;
        }
        //添加
        public Result Add(Procurement_approval procurement_Approval)
        {
            string sql = $"insert into payment_Approval values(null,@name,@type,@texture,@scale,@origin,@number,@describe,@proposer,@expectation,@comment,@create_time,@state,@auditor)";
            Result result = new Result();
            bool _bool = procurementRepository.RUD(sql, new
            {

                @name = procurement_Approval.Name,
                @type = procurement_Approval.Type,
                @texture = procurement_Approval.Texture,
                @scale = procurement_Approval.Scale,
                @origin = procurement_Approval.Origin,
                @number = procurement_Approval.Number,
                @describe = procurement_Approval.Describe,
                @proposer = procurement_Approval.Proposer,
                @expectation = procurement_Approval.Expectation,
                @comment = procurement_Approval.Comment,
                @create_time = procurement_Approval.Create_Time,
                @state = procurement_Approval.State,
                @auditor = procurement_Approval.Auditor

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
            string sql = "delete from procurement_Approval where id in(@id)";
            Result result = new Result();
            bool _bool = procurementRepository.RUD(sql, new { @id = Id });
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
        public Result Update(Procurement_approval procurement_Approval, int Id)
        {
            string sql = " update procurement_Approval set name=@name,type=@type,texture=@texture,scale=@scale,origin=@origin,number=@number,describe=@describe,proposer=@proposer,expectation=@expectation,comment=@comment,create_time=@create_time,state=@state,auditor=@auditor where id=@id";
            Result result = new Result();
            bool _bool = procurementRepository.RUD(sql, new
            {
                @name = procurement_Approval.Name,
                @type = procurement_Approval.Type,
                @texture = procurement_Approval.Texture,
                @scale = procurement_Approval.Scale,
                @origin = procurement_Approval.Origin,
                @number = procurement_Approval.Number,
                @describe = procurement_Approval.Describe,
                @proposer = procurement_Approval.Proposer,
                @expectation = procurement_Approval.Expectation,
                @comment = procurement_Approval.Comment,
                @create_time = procurement_Approval.Create_Time,
                @state = procurement_Approval.State,
                @auditor = procurement_Approval.Auditor,
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
