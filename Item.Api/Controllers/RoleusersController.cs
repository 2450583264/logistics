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
    [Authorize]
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
        /// 显示角色用户表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ShowRoleusers() {
            List<Roleusers> data = roleusersService.ShowRoleusers();
            return Ok(new { data=data});
        }
    }
}
