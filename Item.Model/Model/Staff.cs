using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 员工登记表
    /// </summary>
    public class Staff
    {
        public int Id { get; set; }                 //主键
        public string Name { get; set; }            //姓名
        public bool Sex { get; set; }               //性别
        public string Phone { get; set; }           //手机号
        public string Academy { get; set; }         //院校
        public string Specialty { get; set; }       //专业
        public string Address { get; set; }         //家庭住址
        public string Education { get; set; }       //学历
        public string Face { get; set; }            //政治面貌
        public string Nation { get; set; }          //民族
        public string Native_place { get; set; }    //籍贯
        public string Marriage { get; set; }        //婚姻
        public DateTime Birthday { get; set; }      //出生年月
        public string Email { get; set; }           //邮箱
        public string Identity_Card { get; set; }   //身份证
        public int Department { get; set; }         //部门
        public int Position { get; set; }           //职位
        public int Type { get; set; }               //员工类型
        public DateTime Create_Time { get; set; }   //创建时间
    }
}
