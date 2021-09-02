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
    //货主审批service
    public class ShipperService
    {
        private ShipperRepository shipperRepository;
        public ShipperService(ShipperRepository _shipperRepository) {
            shipperRepository = _shipperRepository;
        }
        //显示
        public Result Show()
        {
            string sql = "select * from shipper_Approvals";
            List<Shipper_approval> shipper_Approvals = shipperRepository.Show(sql);
            Result result = new Result();
            result.Code = 200;
            result.Data = shipper_Approvals;
            result.Msg = "查询成功";
            return result;
        }
        //添加
        public Result Add(Shipper_approval shipper_Approval)
        {
            string sql = $"insert into Shipper_approval values(null,@serialId,@title,@unit,@principal,@path,@price,@full_price,@money,@signed_time,@operator,@create_time,@state,@auditor)";
            Result result = new Result();
            bool _bool = shipperRepository.RUD(sql, new
            {

                @serialId = shipper_Approval.SerialId,
                @title = shipper_Approval.Title,
                @unit = shipper_Approval.Unit,
                @principal = shipper_Approval.Principal,
                @path = shipper_Approval.Path,
                @price = shipper_Approval.Price,
                @full_price = shipper_Approval.Full_Price,
                @money = shipper_Approval.Money,
                @signed_time = shipper_Approval.Signed_Time,
                @operator = shipper_Approval.Operator_g,
                @create_time = shipper_Approval.Create_Time,
                @state = shipper_Approval.State,
                @auditor = shipper_Approval.Auditor

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
            string sql = "delete from shipper_Approval where id in(@id)";
            Result result = new Result();
            bool _bool = shipperRepository.RUD(sql, new { @id = Id });
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
        public Result Update(Shipper_approval shipper_Approval, int Id)
        {
            string sql = " update shipper_Approval set serialId=@serialId,title=@title,unit=@unit,principal=@principal,path=@path,price=@price,full_price=@full_price,money=@money,signed_time=@signed_time,operator=@operator,create_time=@create_time,state=@state,auditor=@auditor  where id=@id";
            Result result = new Result();
            bool _bool = shipperRepository.RUD(sql, new
            {
                @serialId = shipper_Approval.SerialId,
                @title = shipper_Approval.Title,
                @unit = shipper_Approval.Unit,
                @principal = shipper_Approval.Principal,
                @path = shipper_Approval.Path,
                @price = shipper_Approval.Price,
                @full_price = shipper_Approval.Full_Price,
                @money = shipper_Approval.Money,
                @signed_time = shipper_Approval.Signed_Time,
                @operator = shipper_Approval.Operator_g,
                @create_time = shipper_Approval.Create_Time,
                @state = shipper_Approval.State,
                @auditor = shipper_Approval.Auditor,
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
