using Item.IRepository.IAudit;
using Item.Model;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AuditService
{
    public class CarriagerService
    {
        ICarriagerRepository  carriagerRepository;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_usersRepository"></param>
        public CarriagerService(ICarriagerRepository _carriagerRepository)
        {
            carriagerRepository = _carriagerRepository;
        }

        //显示
        public Result Show()
        {
            string sql = "select * from carriage_approval";
            List<Carriage_approval> carriage_Approvals = carriagerRepository.Show(sql);
            Result result = new Result();
            result.Code = 200;
            result.Data = carriage_Approvals;
            result.Msg = "查询成功";
            return result;
        }
        //添加
        public Result Add(Carriage_approval carriage_Approval)
        {
            string sql = $"insert into carriage_Approval values(null,@serialId,@title,@unit,@principal,@path,@price,@full_price,@money,@signed_time,@operator,@create_time,@state,@auditor)";
            Result result = new Result();
            bool _bool = carriagerRepository.RUD(sql, new
            {
                @serialId = carriage_Approval.SerialId,
                @title = carriage_Approval.Title,
                @unit = carriage_Approval.Unit,
                @principal = carriage_Approval.Principal,
                @path = carriage_Approval.Path,
                @price = carriage_Approval.Price,
                @full_price = carriage_Approval.Full_Price,
                @money = carriage_Approval.Money,
                @signed_time = carriage_Approval.Signed_Time,
                @operator = carriage_Approval.Operator_g,
                @create_time = carriage_Approval.Create_Time,
                @state = carriage_Approval.State,
                @auditor = carriage_Approval.Auditor

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
            string sql = "delete from carriage_Approval where id in(@id)";
            Result result = new Result();
            bool _bool = carriagerRepository.RUD(sql, new { @id = Id });
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
        public Result Update(Carriage_approval carriage_Approval, int Id)
        {
            string sql = " update carriage_Approval set serialId=@serialId,title=@title,unit=@unit,principal=@principal,path=@path,price=@price,full_price=@full_price,money=@money,signed_time=@signed_time,operator=@operator,create_time=@create_time,state=@state,auditor=@auditor where id=@id";
            Result result = new Result();
            bool _bool = carriagerRepository.RUD(sql, new
            {
                @serialId = carriage_Approval.SerialId,
                @title = carriage_Approval.Title,
                @unit = carriage_Approval.Unit,
                @principal = carriage_Approval.Principal,
                @path = carriage_Approval.Path,
                @price = carriage_Approval.Price,
                @full_price = carriage_Approval.Full_Price,
                @money = carriage_Approval.Money,
                @signed_time = carriage_Approval.Signed_Time,
                @operator = carriage_Approval.Operator_g,
                @create_time = carriage_Approval.Create_Time,
                @state = carriage_Approval.State,
                @auditor = carriage_Approval.Auditor,
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
