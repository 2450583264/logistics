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
    /// 入职审批
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EntryController : ControllerBase
    {
        private EntryService entryService;
        public EntryController(EntryService _entryService)
        {
            entryService = _entryService;
        }
        /// <summary>
        /// Show
        /// </summary>
        /// <returns></returns>
        [Route("Show")]
        [HttpGet]
        public IActionResult Show()
        {
            return Ok(entryService.Show());
        }
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entry_Approval"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public IActionResult Add(Entry_approval entry_Approval)
        {
            try
            {
                return Ok(entryService.Add(entry_Approval));
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
                return Ok(entryService.Delect(Id));
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
        /// <param name="entry_Approval"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("Update")]
        [HttpPost]
        public IActionResult Update(Entry_approval entry_Approval, int Id)
        {
            try
            {
                return Ok(entryService.Update(entry_Approval, Id));
            }
            catch (Exception ex)
            {
                return Ok(ex);
                throw;
            }
        }
    }
}
