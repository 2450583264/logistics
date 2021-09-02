using Item.IRepository.ITrack;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Track
{
    //货主合同跟踪
    public class Shipper_TrackRepository:BaseRepository<Shipper_Track>, IShipper_Trackrepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Shipper_Track> Show(string sql)
        {
            List<Shipper_Track> shipper_Tracks = Show(sql);
            return shipper_Tracks;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
