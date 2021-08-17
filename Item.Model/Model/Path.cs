using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 路线表
    /// </summary>
    public class Path
    {
        public int PathId { get; set; }             //主键
        public string Path_Name { get; set; }       //路线名称
        public string Origin { get; set; }          //起点
        public string Origin_Intro { get; set; }    //起点名称
        public string Terminus { get; set; }        //终点
        public string Terminus_Intro { get; set; }  //终点名称
        public bool Isoutsource { get; set; }       //是否外协
        public string Name { get; set; }            //货主名称
        public string Comment { get; set; }         //备注
        public DateTime Creation_Time { get; set; } //创建时间
        public bool State { get; set; }             //状态
        public string Phone { get; set; }           //货主手机号
        public string Unit { get; set; }            //货主单位
    }
}
