using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Model.Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class Users
    {
        public int UsersId { get; set; }        //主键
        public string Pwd { get; set; }         //密码
        public string Admin { get; set; }       //账号
        public string Name { get; set; }        //姓名
        public int Sex { get; set; }            //性别
        public string Phone { get; set; }       //手机号
        public string Academy { get; set; }     //院校
        public string Specialty { get; set; }   //专业
        public string Home { get; set; }        //家庭住址
        public string Politics_Status { get; set; }//政治面貌
        public string Nation { get; set; }      //民族
        public string Native_Place { get; set; }    //籍贯
        public DateTime Birthday { get; set; }      //出生年月
        public string E_mail { get; set; }          //邮箱
        public string Identity_Card { get; set; }   //身份证
        public int Education { get; set; }          //学历
        public int Marriage { get; set; }           //婚姻
        public int State { get; set; }              //状态
    }
}
