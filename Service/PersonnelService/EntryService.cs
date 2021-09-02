using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Item.IRepository.IPersonnel;
using Item.Model;
using Item.Model.Model;

namespace Service.PersonnelService
{
    //入职办理
    public class EntryService
    {
        IEntryResponse entryResponse;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_usersRepository"></param>
        public EntryService(IEntryResponse _entryResponse)
        {
            entryResponse = _entryResponse;
        }
        //显示
        public Result Show()
        {
            string sql = "select * from entries";
            List<Entry> entries = entryResponse.Show(sql);
            Result result = new Result();
            result.Data = entries;
            result.Code = 200;
            return result;
        }
        //添加
        public Result Add(Entry entry)
        {
            string sql = "insert into entry values(null,@name,@sex,@department,@post,@superior,@entry_time,@establish_time,@state,@audit,@comment)";
            Result result = new Result();
            bool _bool = entryResponse.RUD(sql, new
            {
                @name = entry.Name,
                @sex = entry.Sex,
                @department = entry.Department,
                @post = entry.Post,
                @superior = entry.Superior,
                @entry_time = entry.Entry_Time,
                @establish_time = entry.Establish_Time,
                @state = entry.State,
                @audit = entry.Audit,
                @comment = entry.Comment
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
            string sql = "delete from entry where Id in(@Id)";
            Result result = new Result();
            bool _bool = entryResponse.RUD(sql, new { @Id = Id });
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
        public Result Update(Entry entry, int Id)
        {
            string sql = " update entry set @name,@sex,@department,@post,@superior,@entry_time,@establish_time,@state,@audit,@comment where Id=@Id";
            Result result = new Result();  
            bool _bool = entryResponse.RUD(sql, new
            {
                @name = entry.Name,
                @sex = entry.Sex,
                @department = entry.Department,
                @post = entry.Post,
                @superior = entry.Superior,
                @entry_time = entry.Entry_Time,
                @establish_time = entry.Establish_Time,
                @state = entry.State,
                @audit = entry.Audit,
                @comment = entry.Comment,
                @Id = Id
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
