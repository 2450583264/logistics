﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    [Authorize]
    public class FuelController : ControllerBase
    {
    }
}
