using Item.IRepository.IFinance;
using Item.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Repository.Finance
{
    //进程发票
    public class CourseRepository:BaseRepository<Course>, ICourseRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<Course> Show(string sql)
        {
            List<Course> courses = Show(sql);
            return courses;
        }

        public bool RUD(string sql)
        {
            bool _bool = RUD(sql);
            return _bool;
        }
    }
}
