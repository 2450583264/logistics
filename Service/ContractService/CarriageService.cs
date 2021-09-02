using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Item.IRepository.IContract;
using Item.Model;
using Item.Model.Model;

namespace Service.ContractService
{
    public class CarriageService
    {
        ICarriageRepository carriageRepository;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_usersRepository"></param>
        public CarriageService(ICarriageRepository _carriageRepository)
        {
            carriageRepository = _carriageRepository;
        }
        //显示
        public Result Show()
        {
            string sql = "select * from carriagecontract";
            List<Carriagecontract> carriagecontracts = carriageRepository.Show(sql);
            Result result = new Result();
            result.Data = carriagecontracts;
            result.Code = 200;
            return result;
        }
        //添加
        public Result Add(Carriagecontract carriagecontract)
        {
            string sql = "insert into carriagecontract values(null,)";
            Result result = new Result();
            bool _bool = carriageRepository.RUD(sql, new
            {
               
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
            string sql = "delete from carriagecontract where  in(@)";
            Result result = new Result();
            bool _bool = carriageRepository.RUD(sql, new { @fuelId = Id });
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
        public Result Update(Carriagecontract carriagecontract, int Id)
        {
            string sql = " update carriagecontract set  where ";
            Result result = new Result();
            bool _bool = carriageRepository.RUD(sql, new
            {
                
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
