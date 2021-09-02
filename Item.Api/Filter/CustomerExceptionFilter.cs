using Item.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Item.Api.Filter
{
    /// <summary>
    /// 自定义异常过滤器
    /// </summary>
    public class CustomerExceptionFilter : IAsyncExceptionFilter
    {
        //日志


        private readonly ILogger<CustomerExceptionFilter> _logger;


        public CustomerExceptionFilter(ILogger<CustomerExceptionFilter> logger)
        {
            _logger = logger;
        }
        
        /// <summary>
        /// 重写OnExceptionAsync方法，定义自己的处理逻辑
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task OnExceptionAsync(ExceptionContext context)
        {
            //记录异常
            _logger.LogError($"{context.Exception.Message}——错误信息");
            // 如果异常没有被处理则进行处理
            if (context.ExceptionHandled == false)
            {
                // 定义返回类型
                var result = new ResultModel<string>
                {
                    ResultCode = 0,
                    ResultMsg = context.Exception.Message
                };
                context.Result = new ContentResult
                {
                    // 返回状态码设置为200，表示成功
                    StatusCode = StatusCodes.Status200OK,                                     
                    // 设置返回格式
                    ContentType = "application/json;charset=utf-8",
                    Content = JsonConvert.SerializeObject(result)
                };
            }
            // 设置为true，表示异常已经被处理了
            //当你处理完异常之后，一定要将此属性更改为true，表示异常已经处理过了，这样其他地方就不会在处理这个异常了
            context.ExceptionHandled = true;
            return Task.CompletedTask;
        }
    }
}
