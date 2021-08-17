using System;

namespace Item.Model.Model
{
    /// <summary>
    /// 事故记录表
    /// </summary>
    public class Accident
    {
        public int Id { get; set; }             //主键                    
        public string Title { get; set; }       //事故标题
        public string License_Plate { get; set; }   //车牌号
        public string Incident { get; set; }        //事发人
        public DateTime Accident_Date { get; set; } //事故日期
        public float Compensation { get; set; }     //保险箱公司赔偿
        public float Net_Loss { get; set; }         //公司净损失
        public string Describe { get; set; }        //事故描述
        public string Direct { get; set; }          //直接经济损失
        public string Comment { get; set; }         //备注
        public DateTime Create_time { get; set; }   //创建时间

    }
}
