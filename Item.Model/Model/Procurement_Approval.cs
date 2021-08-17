using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 采购审批表
    /// </summary>
    public class Procurement_approval
    {
        public int Id { get; set; }             //主键
        public string Name { get; set; }        //货物名称
        public string Type { get; set; }        //类型
        public string Texture { get; set; }     //材质
        public string Scale { get; set; }       //规模
        public string Origin { get; set; }      //产地
        public int Number { get; set; }         //数量
        public string Describe { get; set; }    //用途描述
        public string Proposer { get; set; }    //申请人
        public DateTime Expectation { get; set; }//期望交付日期
        public string Comment { get; set; }     //备注
        public DateTime Create_Time { get; set; }//创建时间
        public int State { get; set; }          //状态
        public string Auditor { get; set; }     //审批人
    }
}
