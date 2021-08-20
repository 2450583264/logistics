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
using Item.Model;
using Item.Common.Token;
using Microsoft.AspNetCore.Authorization;

namespace Item.Api.Controllers
{
    /// <summary>
    /// User控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        private readonly Token token;

        private UsersService UsersService;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="usersService"></param>
        public UsersController(UsersService usersService, ILogger<UsersController> logger, Token _token) {
            UsersService = usersService;

            _logger = logger;

            token = _token;
        }
        /// <summary>
        /// 显示用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public IActionResult Show() {
            List<Users> list= UsersService.Show();
            Result result = new Result();
            try
            {
                result.Data = list;
                result.Msg = "成功";
                result.Code = 200;

                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Msg = "失败，请看错误信息";
                return Ok(new { ex,result});
                throw;
            }
            
            
        }
        /// <summary>
        ///登录
        /// </summary>
        /// <param name="Admin"></param>
        /// <param name="Pwd"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login(string Admin="", string Pwd="") {
            //_logger.LogInformation($"{Admin}在{DateTime.Now}登录了");
            try
            {
                List<Users> data = UsersService.Login(Admin, Pwd);
                Result result = new Result();
                if (data.Count() > 0)
                {
                    result.Data = data;
                    result.Code = 200;
                    result.Msg = "登录成功";

                     //_logger.LogInformation($"{DateTime.Now.ToString("yyyy年MM月dd日 hh:mm:ss")}登陆成功");
                    return Ok(new { result, token = token.Authenticate() });
                }
                else
                {
                    //_logger.LogInformation($"{DateTime.Now.ToString("yyyy年MM月dd日 hh:mm:ss")}登陆失败");
                    return Ok(new { data = "", code = 500, msg = "失败" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,"错误信息");
                throw;
            }
           
            
        }



    }
}
