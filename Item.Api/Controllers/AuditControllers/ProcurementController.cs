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
    /// 采购审批
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProcurementController : ControllerBase
    {
        private ProcurementService procurementService;
        public ProcurementController(ProcurementService _procurementService)
        {
            procurementService = _procurementService; ;
        }
        /// <summary>
        /// Show
        /// </summary>
        /// <returns></returns>
        [Route("Show")]
        [HttpGet]
        public IActionResult Show()
        {
            return Ok(procurementService.Show());
        }
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="procurement_Approval"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public IActionResult Add(Procurement_approval procurement_Approval)
        {
            try
            {
                return Ok(procurementService.Add(procurement_Approval));
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
                return Ok(procurementService.Delect(Id));
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
        /// <param name="procurement_Approval"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("Update")]
        [HttpPost]
        public IActionResult Update(Procurement_approval procurement_Approval, int Id)
        {
            try
            {
                return Ok(procurementService.Update(procurement_Approval, Id));
            }
            catch (Exception ex)
            {
                return Ok(ex);
                throw;
            }
        }
    }
}
