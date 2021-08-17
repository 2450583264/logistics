using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model
{
    /// <summary>
    /// 分页
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageList<T>
    {
        public List<T> Data { get; set; }       //数据

        public int PageIndex { get; set; }      //第几页

        public int PageSize { get; set; }       //一页多少条

        public int TotalRecordCount { get; set; }   //全部的记录总共多少条

        //  总条数/每页条数+总条数%每页条数==0?0:1;
        public int TotalPageCount { get { return TotalRecordCount / PageSize + TotalRecordCount % PageSize == 0 ? 0 : 1; } }    //一共需要多少页
    }
}
