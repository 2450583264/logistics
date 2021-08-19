using Item.IRepository.Basic;
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
    }
}
