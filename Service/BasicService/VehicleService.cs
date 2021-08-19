using Item.IRepository.Basic;
using Item.Model;
using Item.Model.Model;
using Item.Repository.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class VehicleService
    {
        IVehicleRepository vehicleRepository;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_usersRepository"></param>
        public VehicleService(IVehicleRepository _vehicleRepository)
        {
            vehicleRepository = _vehicleRepository;
        }
        public Result Show() {
            string sql = "select * from Vehicle";
            List<Vehicle> vehicles = vehicleRepository.Show(sql);
            Result result = new Result();
            result.Code = 200;
            result.Data = vehicles;
            result.Msg = "查询成功";
            return result;
        }
        //添加
        public Result Add(Vehicle vehicle) {
            string sql = $"insert into Vehicle values(null,@brandId,@plate_number,@Name,@company,@long,@wide,@tall,@color,@buy_tiem,@certificate,@expire_time,@yearexpire_time,@maintain,@vehicle_image,@insurance_image)";
            Result result = new Result();
            bool _bool = vehicleRepository.RUD(sql, new
            {
                @brandId = vehicle.BrandId,
                @plate_number = vehicle.Plate_Number,
                @Name = vehicle.Name,
                @company = vehicle.Company,
                @long = vehicle.@long,
                @wide = vehicle.Wide,
                @tall = vehicle.Tall,
                @color = vehicle.Color,
                @buy_tiem = vehicle.Buy_Tiem,
                @certificate = vehicle.Certificate,
                @expire_time = vehicle.Expire_Time,
                @yearexpire_time = vehicle.Yearexpire_Time,
                @maintain = vehicle.Maintain,
                @vehicle_image = vehicle.Vehicle_Image,
                @insurance_image = vehicle.Insurance_Image
            });
            if (_bool == true)
            {
                result.Msg = "添加成功";
                result.Code = 200;
            }
            else { 
                result.Msg = "添加失败";
                result.Code = 500;
            }
            return result;
        }
        //批删（可用于单删）
        public Result Delect(string Id) {
            string sql = "delete from vehicle where vehicleId in(@vehicleId)";
            Result result = new Result();
            bool _bool = vehicleRepository.RUD(sql,new { @vehicleId=Id });
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
        public Result Update(Vehicle vehicle,int Id) {
            string sql = " update students set brandId=@brandId,plate_number=@plate_number,Name=@Name,company=@company,long=@long,wide=@wide,tall=@tall,color=@color,buy_tiem=@buy_tiem,certificate=@certificate,expire_time=@expire_time,yearexpire_time=@yearexpire_time,maintain=@maintain,vehicle_image=@vehicle_image,insurance_image=@insurance_image where vehicleId =@vehicleId ";
            Result result = new Result();
            bool _bool = vehicleRepository.RUD(sql, new
            {
                @brandId = vehicle.BrandId,
                @plate_number = vehicle.Plate_Number,
                @Name = vehicle.Name,
                @company = vehicle.Company,
                @long = vehicle.@long,
                @wide = vehicle.Wide,
                @tall = vehicle.Tall,
                @color = vehicle.Color,
                @buy_tiem = vehicle.Buy_Tiem,
                @certificate = vehicle.Certificate,
                @expire_time = vehicle.Expire_Time,
                @yearexpire_time = vehicle.Yearexpire_Time,
                @maintain = vehicle.Maintain,
                @vehicle_image = vehicle.Vehicle_Image,
                @insurance_image = vehicle.Insurance_Image,
                @vehicleId=Id
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
