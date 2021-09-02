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
    /// 通用审批
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralController : ControllerBase
    {
        private GeneralService generalService;
        public GeneralController(GeneralService _generalService)
        {
            generalService = _generalService; ;
        }
        /// <summary>
        /// Show
        /// </summary>
        /// <returns></returns>
        [Route("Show")]
        [HttpGet]
        public IActionResult Show()
        {
            return Ok(generalService.Show());
        }
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="general_Approval"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public IActionResult Add(General_approval general_Approval)
        {
            try
            {
                return Ok(generalService.Add(general_Approval));
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
                return Ok(generalService.Delect(Id));
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
        /// <param name="general_Approval"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("Update")]
        [HttpPost]
        public IActionResult Update(General_approval general_Approval, int Id)
        {
            try
            {
                return Ok(generalService.Update(general_Approval, Id));
            }
            catch (Exception ex)
            {
                return Ok(ex);
                throw;
            }
        }
    }
}
