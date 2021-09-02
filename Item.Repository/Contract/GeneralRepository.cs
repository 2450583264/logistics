using Item.IRepository.IContract;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Contract
{
    //通用合同
    public class GeneralRepository:BaseRepository<Generalcontract>, IGeneralRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Generalcontract> Show(string sql)
        {
            List<Generalcontract> generalcontracts = Show(sql);
            return generalcontracts;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
