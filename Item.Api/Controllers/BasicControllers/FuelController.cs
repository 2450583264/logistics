using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.BasicService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Item.Api.Controllers.BasicControllers
{
    /// <summary>
    /// 油费
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FuelController : ControllerBase
    {
        private FuelService fuelService;
        public FuelController(FuelService _fuelService)
        {
            fuelService = _fuelService;
        }
        /// <summary>
        /// 显示油费
        /// </summary>
        /// <returns></returns>
        [Route("Show")]
        [HttpGet]
        public IActionResult Show()
        {
            return Ok(fuelService.Show()); 
        }
        /// <summary>
        /// 油费添加
        /// </summary>
        /// <param name="fuel"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public IActionResult Add(Fuel fuel)
        {
            try
            {
                return Ok(fuelService.Add(fuel));
            }
            catch (Exception ex)
            {
                return Ok(ex);
                throw;
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("Delect")]
        [HttpPost]
        public IActionResult Delect(string Id)
        {
            try
            {
                return Ok(fuelService.Delect(Id));
            }
            catch (Exception ex)
            {
                return Ok(ex);
                throw;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="fuel"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("Update")]
        [HttpPost]
        public IActionResult Update(Fuel fuel, int Id)
        {
            try
            {
                return Ok(fuelService.Update(fuel, Id));
            }
            catch (Exception ex)
            {
                return Ok(ex);
                throw;
            }
        }



    }
}
