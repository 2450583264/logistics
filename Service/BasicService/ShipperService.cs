using Item.IRepository.Basic;
using Item.Repository.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BasicService
{
    public class ShipperService
    {
        IShipperRepository shipperRepository;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_usersRepository"></param>
        public ShipperService(IShipperRepository _shipperRepository)
        {
            shipperRepository = _shipperRepository;
        }
    }
}
