using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 物质统计表
    /// </summary>
    public class Statistics
    {
        public int Id { get; set; }             //主键
        public string Name { get; set; }        //货物名称
        public string Type { get; set; }        //类型
        public string Texture { get; set; }     //材质
        public string Scale { get; set; }       //规模
        public string Origin { get; set; }      //产地
        public int Procurement { get; set; }    //期间采购数量
        public int Receive { get; set; }        //期间领用数量
        public int Surplus { get; set; }        //期间结余数量
    }
}
