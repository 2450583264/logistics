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
    public class RegularizationService
    {
        //转正审批service
        private RegularizationRepository regularizationRepository;

        public RegularizationService(RegularizationRepository _regularizationRepository) {
            regularizationRepository = _regularizationRepository;
        }
        //显示
        public Result Show()
        {
            string sql = "select * from regularization_approval";
            List<Regularization_Approval> regularization_Approvals = regularizationRepository.Show(sql);
            Result result = new Result();
            result.Code = 200;
            result.Data = regularization_Approvals;
            result.Msg = "查询成功";
            return result;
        }
        //添加
        public Result Add(Regularization_Approval regularization_Approval)
        {
            string sql = $"insert into regularization_Approval values(null,@name,@department,@post,@entry,@apply_for,@state,@auditor,@create_time)";
            Result result = new Result();
            bool _bool = regularizationRepository.RUD(sql, new
            {
                @name = regularization_Approval.Name,
                @department = regularization_Approval.Department,
                @post = regularization_Approval.Post,
                @entry = regularization_Approval.Entry,
                @apply_for = regularization_Approval.Apply_For,
                @state = regularization_Approval.State,
                @auditor = regularization_Approval.Auditor,
                @create_time = regularization_Approval.Create_Time
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
            string sql = "delete from regularization_Approval where id in(@id)";
            Result result = new Result();
            bool _bool = regularizationRepository.RUD(sql, new { @id = Id });
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
        public Result Update(Regularization_Approval regularization_Approval, int Id)
        {
            string sql = " update regularization_Approval set name=@name,department=@department,post=@post,entry=@entry,apply_for=@apply_for,state=@state,auditor=@auditor,create_time=@create_time where id=@id";
            Result result = new Result();
            bool _bool = regularizationRepository.RUD(sql, new
            {
                @name = regularization_Approval.Name,
                @department = regularization_Approval.Department,
                @post = regularization_Approval.Post,
                @entry = regularization_Approval.Entry,
                @apply_for = regularization_Approval.Apply_For,
                @state = regularization_Approval.State,
                @auditor = regularization_Approval.Auditor,
                @create_time = regularization_Approval.Create_Time,
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
