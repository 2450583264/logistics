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
    /// 转正审批
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RegularizationController : ControllerBase
    {
        private RegularizationService regularizationService;
        public RegularizationController(RegularizationService _regularizationService)
        {
            regularizationService = _regularizationService;
        }
        /// <summary>
        /// Show
        /// </summary>
        /// <returns></returns>
        [Route("Show")]
        [HttpGet]
        public IActionResult Show()
        {
            return Ok(regularizationService.Show());
        }
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="regularization_Approval"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public IActionResult Add(Regularization_Approval regularization_Approval)
        {
            try
            {
                return Ok(regularizationService.Add(regularization_Approval));
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
                return Ok(regularizationService.Delect(Id));
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
        /// <param name="regularization_Approval"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("Update")]
        [HttpPost]
        public IActionResult Update(Regularization_Approval regularization_Approval, int Id)
        {
            try
            {
                return Ok(regularizationService.Update(regularization_Approval, Id));
            }
            catch (Exception ex)
            {
                return Ok(ex);
                throw;
            }
        }
    }
}
