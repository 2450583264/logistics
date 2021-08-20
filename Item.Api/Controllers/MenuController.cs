using Item.IRepository;
using Item.Model.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service;
using Item.Common.DB;
using Microsoft.AspNetCore.Authorization;

namespace Item.Api.Controllers
{
    /// <summary>
    /// Menu控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class MenuController : ControllerBase
    {

        MenuService menuService;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_menuService"></param>
        public MenuController(MenuService _menuService)
        {
            menuService = _menuService;
        }
        /// <summary>
        /// 菜单显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Show()
        {
            List<Menu> list = menuService.Show();
            return Ok(list);
        }
        /// <summary>
        /// 菜单权限显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Trees(string d)
        {
            
            List<Menu> treeDates = menuService.Show();
            List<Menu> list = Dapper<Menu>.Query($"select * from menu where menuId in({d}) ");
            List<Dictionary<string, object>> jsonList = new List<Dictionary<string, object>>();
            foreach (var item in list)
            {
                Dictionary<string, object> json = new Dictionary<string, object>();
                json.Add("id", item.MenuId);
                json.Add("title", item.MenuName);
                Tree_Next(treeDates, json, item.MenuId);
                jsonList.Add(json);

            }
            return Ok(jsonList);
        }
        private void Tree_Next(List<Menu> treeDates, Dictionary<string, object> json, int id)
        {
            List<Menu> list = treeDates.Where(x => x.MenuWId.Equals(id)).ToList();
            List<Dictionary<string, object>> jsonList = new List<Dictionary<string, object>>();
            if (list.Count == 0)
            {
                //json.Add("children", null);
                return;
            }
            foreach (var item in list)
            {
                Dictionary<string, object> json1 = new Dictionary<string, object>();
                json1.Add("id", item.MenuId);
                json1.Add("title", item.MenuName);

                Tree_Next(treeDates, json1, item.MenuId);
                jsonList.Add(json1);

            }
            json.Add("children", jsonList);
        }


    }
}
