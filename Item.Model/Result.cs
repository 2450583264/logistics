using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model
{
    /// <summary>
    /// 返回数据
    /// </summary>
    public class Result
    {
        public int Code { get; set; }// 0 失败 1成功
        public string Msg { get; set; }//错误消息
        public object Data { get; set; }    //数据
    }
}
