using Item.IRepository.ITrack;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Track
{
    //承运合同跟踪
    public class Carriage_TrackRepository:BaseRepository<Carriage_Track>, ICarriage_TrackRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Carriage_Track> Show(string sql)
        {
            List<Carriage_Track> carriage_Tracks = Show(sql);
            return carriage_Tracks;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
