using Item.Model;
using Item.Model.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Item.Api.Controllers
{
    /// <summary>
    /// 角色用户表
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]         //添加权限特效
    public class RoleusersController : ControllerBase
    {
        RoleusersService roleusersService;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_roleusersService"></param>
        public RoleusersController(RoleusersService _roleusersService)
        {
            roleusersService = _roleusersService;
        }
        
        /// <summary>
        /// 角色用户查询
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ShowRoleusers(int Id) {
            List<Roleusers> data = roleusersService.ShowRoleusers(Id);
            Result result = new Result();
            return Ok(new { data=data});
        }
    }
}
