using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 轮胎使用记录表
    /// </summary>
    public class Tyre
    {
        public int Id { get; set; }                 //主键
        public string License_Plate { get; set; }   //车牌号
        public string Brand { get; set; }           //轮胎品牌
        public string Standard { get; set; }        //规范
        public int Number { get; set; }             //数量
        public string User { get; set; }            //使用人
        public DateTime Use_Time { get; set; }      //使用日期
        public string Comment { get; set; }         //备注
        public DateTime Create_Time { get; set; }   //创建时间
    }
}
