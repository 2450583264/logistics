using Item.Model.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AuditService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Item.Api.Controllers.AuditControllers
{
    /// <summary>
    /// 离职审批
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DimissionConterller : ControllerBase
    {

        private DimissionService dimissionService;
        public DimissionConterller(DimissionService _dimissionService)
        {
            dimissionService = _dimissionService;
        }
        /// <summary>
        /// Show
        /// </summary>
        /// <returns></returns>
        [Route("Show")]
        [HttpGet]
        public IActionResult Show()
        {
            return Ok(dimissionService.Show());
        }
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="dimission_Approval"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public IActionResult Add(Dimission_approval dimission_Approval)
        {
            try
            {
                return Ok(dimissionService.Add(dimission_Approval));
            }
            catch (Exception ex)
            {
                return Ok(ex);
                throw;
            }
        }
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("Delect")]
        [HttpPost]
        public IActionResult Delect(string Id)
        {
            try
            {
                return Ok(dimissionService.Delect(Id));
            }
            catch (Exception ex)
            {
                return Ok(ex);
                throw;
            }
        }

        /// <summary>
        /// UPdate
        /// </summary>
        /// <param name="dimission_Approval"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("Update")]
        [HttpPost]
        public IActionResult Update(Dimission_approval dimission_Approval, int Id)
        {
            try
            {
                return Ok(dimissionService.Update(dimission_Approval, Id));
            }
            catch (Exception ex)
            {
                return Ok(ex);
                throw;
            }
        }
    }
}
