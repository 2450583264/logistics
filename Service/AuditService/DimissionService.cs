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
    public class DimissionService
    {
        private DimissionRepository dimissionRepository;

        public DimissionService(DimissionRepository _dimissionRepository) {
            dimissionRepository = _dimissionRepository;
        }

        //显示
        public Result Show()
        {
            string sql = "select * from Dimission_approval";
            List<Dimission_approval> dimission_Approvals = dimissionRepository.Show(sql);
            Result result = new Result();
            result.Code = 200;
            result.Data = dimission_Approvals;
            result.Msg = "查询成功";
            return result;
        }
        //添加
        public Result Add(Dimission_approval dimission_Approval)
        {
            string sql = $"insert into Dimission_approval values(null,@name,@department,@post,@principal,@entry,@end_day,@cause,@create_time,@state,@auditor)";
            Result result = new Result();
            bool _bool = dimissionRepository.RUD(sql, new
            {
                @name = dimission_Approval.Name,
                @department = dimission_Approval.Department,
                @post = dimission_Approval.Post,
                @principal = dimission_Approval.Principal,
                @entry = dimission_Approval.Entry,
                @end_day = dimission_Approval.End_Day,
                @cause = dimission_Approval.Cause,
                @create_time = dimission_Approval.Create_Time,
                @state = dimission_Approval.State,
                @auditor = dimission_Approval.Auditor
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
            string sql = "delete from dimission_Approval where id in(@id)";
            Result result = new Result();
            bool _bool = dimissionRepository.RUD(sql, new { @id = Id });
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
        public Result Update(Dimission_approval dimission_Approval, int Id)
        {
            string sql = " update dimission_Approval set name=@name,department=@department,post=@post,principal=@principal,entry=@entry,end_day=@end_day,cause=@cause,create_time=@create_time,state=@state,auditor=@auditor where id=@id";
            Result result = new Result();
            bool _bool = dimissionRepository.RUD(sql, new
            {
                @name = dimission_Approval.Name,
                @department = dimission_Approval.Department,
                @post = dimission_Approval.Post,
                @principal = dimission_Approval.Principal,
                @entry = dimission_Approval.Entry,
                @end_day = dimission_Approval.End_Day,
                @cause = dimission_Approval.Cause,
                @create_time = dimission_Approval.Create_Time,
                @state = dimission_Approval.State,
                @auditor = dimission_Approval.Auditor,
                @id=Id
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
