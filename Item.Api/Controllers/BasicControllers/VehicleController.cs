using Item.Model;
using Item.Model.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Item.Api.Controllers.BasicControllers
{
    /// <summary>
    /// 车辆
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class VehicleController : ControllerBase
    {

        private VehicleService vehicleService;
        public VehicleController(VehicleService _vehicleService) {
            vehicleService = _vehicleService;
        }
        /// <summary>
        /// 显示车辆
        /// </summary>
        /// <returns></returns>
        [Route("Show")]
        [HttpGet]
        public IActionResult Show() {
            try
            {
                return Ok(vehicleService.Show());
            }
            catch (Exception ex)
            {
                return Ok(ex);
                throw;
            }
            
        }
        /// <summary>
        /// 车辆添加
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public IActionResult Add(Vehicle vehicle) {
            try
            {
                return Ok(vehicleService.Add(vehicle));
            }
            catch (Exception ex)
            {
                return Ok(ex);
                throw;
            }
        }
        /// <summary>
        /// 车辆删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("Delect")]
        [HttpPost]
        public IActionResult Delect(string Id) {
            try
            {
                return Ok(vehicleService.Delect(Id));
            }
            catch (Exception ex) 
            {
                return Ok(ex);
                throw;
            }
        }
        
        /// <summary>
        /// 车辆修改
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("Update")]
        [HttpPost]
        public IActionResult Update(Vehicle vehicle,int Id)
        {
            try
            {
                return Ok(vehicleService.Update(vehicle,Id));
            }
            catch (Exception ex)
            {
                return Ok(ex);
                throw;
            }
        }
    }
}
