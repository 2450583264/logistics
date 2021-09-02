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
    public class GeneralService
    {
        private GeneralRepository generalRepository;

        public GeneralService(GeneralRepository _generalRepository) {
            generalRepository = _generalRepository;
        }

        //显示
        public Result Show()
        {
            string sql = "select * from general_approval";
            List<General_approval> general_Approvals = generalRepository.Show(sql);
            Result result = new Result();
            result.Code = 200;
            result.Data = general_Approvals;
            result.Msg = "查询成功";
            return result;
        }
        //添加
        public Result Add(General_approval general_Approval)
        {
            string sql = $"insert into general_Approval values(null,@serialId,@title,@unit,@principal,@type,@signed_time,@operator,@create_time,@state,@auditor)";
            Result result = new Result();
            bool _bool = generalRepository.RUD(sql, new
            {
                @serialId = general_Approval.SerialId,
                @title = general_Approval.Title,
                @unit = general_Approval.Unit,
                @principal = general_Approval.Principal,
                @type = general_Approval.Type,
                @signed_time = general_Approval.Signed_Time,
                @operator = general_Approval.Operator_g,
                @create_time = general_Approval.Create_Time,
                @state = general_Approval.State,
                @auditor = general_Approval.Auditor

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
            string sql = "delete from general_Approval where id in(@id)";
            Result result = new Result();
            bool _bool = generalRepository.RUD(sql, new { @id = Id });
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
        public Result Update(General_approval general_Approval, int Id)
        {
            string sql = " update general_Approval set serialId=@serialId,title=@title,unit=@unit,principal=@principal,type=@type,signed_time=@signed_time,operator=@operator,create_time=@create_time,state=@state,auditor=@auditor where id=@id";
            Result result = new Result();
            bool _bool = generalRepository.RUD(sql, new
            {
                @serialId = general_Approval.SerialId,
                @title = general_Approval.Title,
                @unit = general_Approval.Unit,
                @principal = general_Approval.Principal,
                @type = general_Approval.Type,
                @signed_time = general_Approval.Signed_Time,
                @operator = general_Approval.Operator_g,
                @create_time = general_Approval.Create_Time,
                @state = general_Approval.State,
                @auditor = general_Approval.Auditor,
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
