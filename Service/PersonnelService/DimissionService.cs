
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
    //离职办理
    public class DimissionService
    {
        IDimissionResponse dimissionResponse;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_usersRepository"></param>
        public DimissionService(IDimissionResponse _dimissionResponse)
        {
            dimissionResponse = _dimissionResponse;
        }
        //显示
        public Result Show()
        {
            string sql = "select * from dimission";
            List<Dimission> fuels = dimissionResponse.Show(sql);
            Result result = new Result();
            result.Data = fuels;
            result.Code = 200;
            return result;
        }
        //添加
        public Result Add(Dimission dimission)
        {
            string sql = "insert into dimission values(null,@name,@department,@post,@superior,@entry_time,@end_day,@cause,@state,@create_time)";
            Result result = new Result();
            bool _bool = dimissionResponse.RUD(sql, new
            {
                @name = dimission.Name,
                @department = dimission.Department,
                @post = dimission.Post,
                @superior = dimission.Superior,
                @entry_time = dimission.Entry_Time,
                @end_day = dimission.End_Day,
                @cause = dimission.Cause,
                @state = dimission.State,
                @create_time = dimission.Create_Time
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
            string sql = "delete from Fuel where dimission in(@Id)";
            Result result = new Result();
            bool _bool = dimissionResponse.RUD(sql, new { @Id = Id });
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
        public Result Update(Dimission dimission, int Id)
        {
            string sql = " update Fuel set name=@name,department=@department,post=@post,superior=@superior,entry_time=@entry_time,end_day=@end_day,cause=@cause,state=@state,create_time=@create_time where Id=@Id";
            Result result = new Result();
            bool _bool = dimissionResponse.RUD(sql, new
            {
                @name = dimission.Name,
                @department = dimission.Department,
                @post = dimission.Post,
                @superior = dimission.Superior,
                @entry_time = dimission.Entry_Time,
                @end_day = dimission.End_Day,
                @cause = dimission.Cause,
                @state = dimission.State,
                @create_time = dimission.Create_Time,
                @Id= Id
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
