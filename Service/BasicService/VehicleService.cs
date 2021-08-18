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
        public Result Add(Vehicle vehicle) {
            string sql = $"insert into Vehicle values(null,@brandId,@plate_number,@Name,@company,@long,@wide,@tall,@color,@buy_tiem,@certificate,@expire_time,@yearexpire_time,@maintain,@vehicle_image,@insurance_image)";
            Result result = new Result();
            bool _bool = vehicleRepository.RUD(sql, new
            {
                @brandId = vehicle.BrandId,
                @plate_number = vehicle.Plate_Number,
                @Name = vehicle.Name,
                @company = vehicle.Company,
                @long = vehicle.Long_g,
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

        public Result Delect(int Id) {
            string sql = "delect from vehicle where ";
        }
        public Result Update() { 
        
        }


    }
}
