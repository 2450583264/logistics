using Item.IRepository.Basic;
using Item.Model;
using Item.Model.Model;
using Item.Repository.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BasicService
{
    public class FuelService:FuelRepository
    {
        IFuelRepository fuelRepository;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_usersRepository"></param>
        public FuelService(IFuelRepository  _fuelRepository)
        {
            fuelRepository = _fuelRepository;
        }

        //显示
        public Result Show()
        {
            string sql = "select * from fue";
            List<Fuel> fuels= fuelRepository.Show(sql);
            Result result = new Result();
            result.Code = 200;
            result.Data = fuels;
            result.Msg = "查询成功";
            return result;
        }
        //添加
        public Result Add(Fuel fuel)
        {
            string sql = $"insert into Vehicle values(null,@plate_number,@cost,@oil_mass,@km,@pay,@broker,@comment,@creation_time)";
            Result result = new Result();
            bool _bool = fuelRepository.RUD(sql, new
            {
                @plate_number=fuel.Plate_number,
                @cost=fuel.Cost,
                @oil_mass=fuel.Cost,
                @km=fuel.Km,
                @pay=fuel.Pay,
                @broker=fuel.Broker,
                @comment=fuel.Comment,
                @creation_time=fuel.Creation_Time

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
            string sql = "delete from vehicle where fuelId in(@FuelId)";
            Result result = new Result();
            bool _bool = fuelRepository.RUD(sql, new { @FuelId = Id });
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
        public Result Update(Fuel fuel, int Id)
        {
            string sql = " update fuel set plate_number=@plate_number,cost=@cost,oil_mass=@oil_mass,km=@km,pay=@pay,broker=@broker,comment=@comment,creation_time=@creation_time where fuelId =@fuelId ";
            Result result = new Result();
            bool _bool = fuelRepository.RUD(sql, new
            {
                
                @plate_number = fuel.Plate_number,
                @cost = fuel.Cost,
                @oil_mass = fuel.Cost,
                @km = fuel.Km,
                @pay = fuel.Pay,
                @broker = fuel.Broker,
                @comment = fuel.Comment,
                @creation_time = fuel.Creation_Time,
                @fuelId = Id
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
