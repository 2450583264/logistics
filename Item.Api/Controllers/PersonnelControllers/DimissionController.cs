using Item.Model.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.PersonnelService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Item.Api.Controllers.PersonnelControllers
{
    /// <summary>
    /// 离职办理
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DimissionController : ControllerBase
    {
        //private DimissionService dimissionService;
        //public DimissionController(DimissionService _dimissionService)
        //{
        //    dimissionService = _dimissionService;
        //}
        ///// <summary>
        ///// Show
        ///// </summary>
        ///// <returns></returns>
        //[Route("Show")]
        //[HttpGet]
        //public IActionResult Show()
        //{
        //    return Ok(dimissionService.Show());
        //}
        ///// <summary>
        ///// Add
        ///// </summary>
        ///// <param name="dimission"></param>
        ///// <returns></returns>
        //[Route("Add")]
        //[HttpPost]
        //public IActionResult Add(Dimission dimission)
        //{       
        //    return Ok(dimissionService.Add(dimission));
        //}
        ///// <summary>
        ///// Delete
        ///// </summary>
        ///// <param name="Id"></param>
        ///// <returns></returns>
        //[Route("Delect")]
        //[HttpPost]
        //public IActionResult Delect(string Id)
        //{
        //     return Ok(dimissionService.Delect(Id));
        //}

        ///// <summary>
        ///// Update
        ///// </summary>
        ///// <param name="dimission"></param>
        ///// <param name="Id"></param>
        ///// <returns></returns>
        //[Route("Update")]
        //[HttpPost]
        //public IActionResult Update(Dimission dimission, int Id)
        //{
        //     return Ok(dimissionService.Update(dimission, Id));
        //}
    }
}
