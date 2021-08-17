using Item.IRepository;
using Item.Model.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service;
using Microsoft.Extensions.Logging;

namespace Item.Api.Controllers
{
    /// <summary>
    /// User控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        
        UsersService UsersService;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_usersRepository"></param>
        public UsersController(UsersService UsersService1) {
            UsersService = UsersService1;
        }
        /// <summary>
        /// 显示用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Show() {
            List<Users> list= UsersService.Show();
            return Ok(list);
        }
        /// <summary>
        ///登录
        /// </summary>
        /// <param name="Admin"></param>
        /// <param name="Pwd"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login(string Admin="", string Pwd="") {
            List<Users> data = UsersService.Login(Admin,Pwd);
            int i = data.Count();
            if (i>0) {
                return Ok(new {data=data,code=200,msg="成功" });
            }
            else {
                return Ok(new {data="",code=500,msg="失败" });
            }
        }



    }
}
