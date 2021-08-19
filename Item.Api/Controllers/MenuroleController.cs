using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service;
using Item.Model.Model;

namespace Item.Api.Controllers
{
    /// <summary>
    /// 角色菜单表
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MenuroleController : ControllerBase
    {
        MenuroleService menuroleService;
        public MenuroleController(MenuroleService _menuroleService) {
            menuroleService = _menuroleService;
        }
        /// <summary>
        /// 显示菜单角色表信息
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ShowMenurole(int RoleId)
        {
            List<Menurole> data = menuroleService.showMenurole(RoleId);
            string d = "";
            foreach (var item in data)
            {
                d += ","+item.MenuId;
            }
            d = d.Substring(1,d.Length-1);
            return Ok(new { data=data,d=d });
        }
    }
}
