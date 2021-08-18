using Item.Model;
using Item.Model.Model;
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
    public class VehicleController : ControllerBase
    {

        private VehicleService vehicleService;
        public VehicleController(VehicleService _vehicleService) {
            vehicleService = _vehicleService;
        }
        /// <summary>
        /// 显示所有车辆
        /// </summary>
        /// <returns></returns>
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

    }
}
