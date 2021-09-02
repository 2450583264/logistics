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
    public class EntryService
    {
        private EntryRepository entryRepository;

        public EntryService(EntryRepository _entryRepository) {
            entryRepository = _entryRepository;
        }
        //显示
        public Result Show()
        {
            string sql = "select * from entry_approval";
            List<Entry_approval> entry_Approvals = entryRepository.Show(sql);
            Result result = new Result();
            result.Code = 200;
            result.Data = entry_Approvals;
            result.Msg = "查询成功";
            return result;
        }
        //添加
        public Result Add(Entry_approval entry_Approval)
        {
            string sql = $"insert into entry_approval values(null,@name,@department,@post,@principal,@entry,@create_time,@state,@auditor)";
            Result result = new Result();
            bool _bool = entryRepository.RUD(sql, new
            {
                @name = entry_Approval.Name,
                @department = entry_Approval.Department,
                @post = entry_Approval.Post,
                @principal = entry_Approval.Principal,
                @entry = entry_Approval.Entry,
                @create_time = entry_Approval.Create_Time,
                @state = entry_Approval.State,
                @auditor = entry_Approval.Auditor

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
            string sql = "delete from entry_Approval where id in(@id)";
            Result result = new Result();
            bool _bool = entryRepository.RUD(sql, new { @id = Id });
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
        public Result Update(Entry_approval entry_Approval, int Id)
        {
            string sql = " update entry_Approval set name=@name,department=@department,post=@post,principal=@principal,entry=@entry,create_time=@create_time,state=@state,auditor=@auditor where id=@id";
            Result result = new Result();
            bool _bool = entryRepository.RUD(sql, new
            {
                @name = entry_Approval.Name,
                @department = entry_Approval.Department,
                @post = entry_Approval.Post,
                @principal = entry_Approval.Principal,
                @entry = entry_Approval.Entry,
                @create_time = entry_Approval.Create_Time,
                @state = entry_Approval.State,
                @auditor = entry_Approval.Auditor,
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
